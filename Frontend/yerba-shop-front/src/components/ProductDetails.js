import { useState } from "react";
import { useParams } from "react-router";
import useFetch from "../fetch_api/useFetch";
import Button from "@material-ui/core/Button";
import Typography from "@material-ui/core/Typography";
import Container from "@material-ui/core/Container";
import ButtonGroup from "@material-ui/core/ButtonGroup";
import AddIcon from "@material-ui/icons/Add";
import RemoveIcon from "@material-ui/icons/Remove";
import AddShoppingCartIcon from "@material-ui/icons/AddShoppingCart";
import ShoppingCartIcon from "@material-ui/icons/ShoppingCart";

const ProductDetails = () => {
  const [quant, setQuant] = useState(0);

  const { id } = useParams();
  const { data: product, error, isPending } = useFetch(
    "http://localhost:8000/products/" + id
  );

  const handleClick = (e) => {
    if (e === "add") {
      setQuant(quant + 1);
    }
    if (e === "rem") {
      if (quant !== 0) setQuant(quant - 1);
      else setQuant(0);
    }
  };

  return (
    <div>
      {isPending && <div className="load">Loading...</div>}
      {error && <div>{error}</div>}

      {product && (
        <div className="product-details">
          <img src={product.ImageLink} alt="ProductImage" />
          <div className="text">
            <h2>{product.ProductName}</h2>
            <p>Opis produktu:</p>
            <div className="desc">{product.LongDescription}</div>
            <p className="price">Cena: {product.ProductPrice} zł KUP TERAZ!!</p>
            <div className="quant">
              <Button
                variant="contained"
                color="primary"
                onClick={() => handleClick("rem")}
              >
                <RemoveIcon />
              </Button>
              Sztuk: {quant}
              <Button
                variant="contained"
                color="primary"
                onClick={() => handleClick("add")}
              >
                <AddIcon />
              </Button>
            </div>
            <Container disableGutters>
              <Typography variant="h5">
                Koszt: {Math.round(product.ProductPrice * quant * 100) / 100} zł
              </Typography>
              <ButtonGroup variant="contained" color="primary">
                <Button endIcon={<ShoppingCartIcon />}>Zamów teraz</Button>
                <Button endIcon={<AddShoppingCartIcon />}>
                  Dodaj do koszyka
                </Button>
              </ButtonGroup>
            </Container>
          </div>
        </div>
      )}
    </div>
  );
};

export default ProductDetails;
