import { useState } from "react";
import useFetch from "../fetch_api/useFetch";
import ProductList from "./ProductList";
import {
  FormControl,
  InputLabel,
  Menu,
  MenuItem,
  Select,
} from "@material-ui/core";
const Home = () => {
  const { data: products, isPending, error } = useFetch(
    "http://localhost:8000/products"
  );

  const [brand, setBrand] = useState("");
  const [weight, setWeight] = useState("");
  const [country, setCountry] = useState("");

  // only single-choice for now :/
  const handleBrandChange = (event) => {
    setBrand(event.target.value);
    setWeight("");
    setCountry("");
  };
  const handleWeightChange = (event) => {
    setWeight(event.target.value);
    setBrand("");
    setCountry("");
  };
  const handleCountryChange = (event) => {
    setCountry(event.target.value);
    setBrand("");
    setWeight("");
  };

  let BrandArr = ["Amanda", "Mateine"];
  let WeightArr = ["0.5", "1"];
  let CountryArr = ["Paragwaj", "Argentyna"];

  return (
    <div className="home">
      {isPending && <div className="load">Loading...</div>}
      {error && <div> {error} </div>}
      {products && (
        <div className="search">
          Filtruj:
          <FormControl className="search-form">
            <InputLabel>Marka</InputLabel>
            <Select
              native
              value={brand}
              onChange={handleBrandChange}
              inputProps={{
                name: "Marka",
                id: "brand-label",
              }}
            >
              <option aria-label="none" value="">
                Marka
              </option>
              {BrandArr.map((brandVal) => {
                return <option value={brandVal}>{brandVal}</option>;
              })}
            </Select>
          </FormControl>
          <FormControl className="search-form">
            <InputLabel>Waga</InputLabel>
            <Select
              native
              value={weight}
              onChange={handleWeightChange}
              nputProps={{
                name: "Waga",
                id: "weight-label",
              }}
            >
              <option aria-label="none" value="">
                Waga
              </option>

              {WeightArr.map((weighVal) => {
                return <option value={weighVal}>{weighVal}</option>;
              })}
            </Select>
          </FormControl>
          <FormControl className="search-form">
            <InputLabel>Kraj</InputLabel>
            <Select
              native
              value={country}
              onChange={handleCountryChange}
              nputProps={{
                name: "Kraj",
                id: "country-label",
              }}
            >
              <option aria-label="none" value="">
                Kraj
              </option>

              {CountryArr.map((countryVal) => {
                return <option value={countryVal}>{countryVal}</option>;
              })}
            </Select>
          </FormControl>
        </div>
      )}

      {/* <div>Marka: {brand}</div>
      <div>waga: {weight}</div> */}

      {products && (
        <ProductList
          products={products.filter((product) => {
            if (brand) return product.ProductBrand === brand;
            if (weight) return product.ProductWeight === weight;
            if (country) return product.Country === country;
            if (!brand) return product;
          })}
        />
      )}
    </div>
  );
};

export default Home;
