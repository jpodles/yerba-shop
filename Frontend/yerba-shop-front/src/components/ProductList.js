import React, { useEffect, useState } from "react";
import { Link } from "react-router-dom";
import { FormControl, InputLabel, Select } from "@material-ui/core";
import Chip from "@material-ui/core/Chip";
import ClearIcon from "@material-ui/icons/Clear";
import Button from "@material-ui/core/Button";

const ProductList = ({ products }) => {
  const [items, setProducts] = useState(products);
  const [country, setCountry] = useState("");
  const [weight, setWeight] = useState("");
  const [brand, setBrand] = useState("");

  const handleFilterChange = (e, filterType) => {
    switch (filterType) {
      case "country":
        setCountry(e.target.value);
        break;
      case "weight":
        setWeight(e.target.value);
        break;
      case "brand":
        setBrand(e.target.value);
        break;
      default:
        break;
    }
  };

  const handleDelete = (e) => {
    if (e === "weight") {
      setWeight("");
    }
    if (e === "brand") {
      setBrand("");
    }
    if (e === "country") {
      setCountry("");
    }
  };

  useEffect(() => {
    let filteredProducts = products;
    if (country !== "") {
      filteredProducts = filteredProducts.filter(
        (product) => product.Country === country
      );
    }
    if (weight !== "") {
      filteredProducts = filteredProducts.filter(
        (product) => product.ProductWeight === weight
      );
    }
    if (brand !== "") {
      filteredProducts = filteredProducts.filter(
        (product) => product.ProductBrand === brand
      );
    }

    setProducts(filteredProducts);
  }, [country, weight, brand]);

  const handleReset = () => {
    let dropCountry = document.getElementById("country-select");
    let dropWeight = document.getElementById("weight-select");
    let dropBrand = document.getElementById("brand-select");
    dropCountry.selectedIndex = "";
    dropWeight.selectedIndex = "";
    dropBrand.selectedIndex = "";
  };

  return (
    <React.Fragment>
      <div className="search">
        <span>Filtruj:</span>
        <FormControl className="search-form">
          {/* <InputLabel id="country-label">Kraj</InputLabel> */}
          <Select
            native
            value={products.Country}
            id="country-select"
            labelId="country-label"
            onChange={(e) => handleFilterChange(e, "country")}
            onClick={() => handleReset()}
          >
            {/* <option aria-label="Country select" value="0" /> */}
            <option value="">Kraj</option>
            <option value="Argentyna">Argentyna</option>
            <option value="Paragwaj">Paragwaj</option>
          </Select>
        </FormControl>
        <FormControl className="search-form">
          {/* <InputLabel id="weight-label">Waga</InputLabel> */}
          <Select
            native
            value={products.ProductWeight}
            id="weight-select"
            labelId="weight-label"
            onChange={(e) => handleFilterChange(e, "weight")}
            onClick={() => handleReset()}
          >
            {/* <option aria-label="Weight select" value="" /> */}
            <option value="">Waga</option>
            <option value="1">1 kg</option>
            <option value="0.5">0.5 kg</option>
          </Select>
        </FormControl>
        <FormControl className="search-form">
          {/* <InputLabel id="brand-label">Marka</InputLabel> */}
          <Select
            native
            value={products.ProductBrand}
            id="brand-select"
            labelId="brand-label"
            onChange={(e) => handleFilterChange(e, "brand")}
            onClick={() => handleReset()}
          >
            {/* <option aria-label="Brand select" value="" /> */}
            <option value="all">Marka</option>
            <option value="Amanda">Amanda</option>
            <option value="Mateine">Mateine</option>
          </Select>
        </FormControl>

        <div>
          <div className="chips">
            {country && (
              <Chip
                label={country}
                color="primary"
                deleteIcon={<ClearIcon />}
                onDelete={() => handleDelete("country")}
              />
            )}
            {weight && (
              <Chip
                label={weight + " kg"}
                color="primary"
                deleteIcon={<ClearIcon />}
                onDelete={() => handleDelete("weight")}
              />
            )}
            {brand && (
              <Chip
                label={brand}
                color="primary"
                deleteIcon={<ClearIcon />}
                onDelete={() => handleDelete("brand")}
              />
            )}
          </div>
        </div>
      </div>

      <div className="product-list">
        {items.map((item, key) => {
          return (
            <Link to={`/products/${item.id}`} key={item.id}>
              <div className="blog-prev" key={item.id}>
                <h2>{item.ProductName}</h2>
                <img src={item.ImageLink} alt="ProductImage" />
                <div className="desc">{item.ShortDescription}</div>
                <div className="price">{item.ProductPrice} zł</div>
              </div>
            </Link>
          );
        })}
      </div>
    </React.Fragment>
  );
};

export default ProductList;
