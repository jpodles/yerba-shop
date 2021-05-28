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
import Divider from "@material-ui/core/Divider";
import ThumbUpAltIcon from "@material-ui/icons/ThumbUpAlt";
import ThumbDownIcon from "@material-ui/icons/ThumbDown";
import Switch from "@material-ui/core/Switch";
import Collapse from "@material-ui/core/Collapse";

import FormControlLabel from "@material-ui/core/FormControlLabel";
import { FormControl, InputLabel } from "@material-ui/core";
import TextField from "@material-ui/core/TextField";

const ProductDetails = () => {
  const [quant, setQuant] = useState(0);
  const [checked, setChecked] = useState(false);
  const handleChange = () => {
    setChecked((prev) => !prev);
  };
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
          <img src={product.ProductImage} alt="ProductImage" />
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
      {product && (
        <Container disableGutters className="reviews">
          <Button variant="contained" color="primary" onClick={handleChange}>
            Dodaj recenzje
          </Button>
          <Collapse in={checked}>
            <FormControl className="test-form">
              <TextField
                className="input-body"
                id="review-body"
                multiline
                rows={4}
                label="Treść recenzji"
              />
              <Button variant="contained" color="primary">
                Wyślij
              </Button>
            </FormControl>
          </Collapse>
          <Typography className="reviews-header">Recenzje:</Typography>

          {product.Reviews.map((item, key) => {
            return (
              <Container key={item.Id} className="review">
                {/* <Container
                  component="span"
                  disableGutters
                  className="review-type"
                > */}
                {item.TypeOfReview === "Like" && (
                  <ThumbUpAltIcon htmlColor="#4caf50" />
                )}
                {item.TypeOfReview === "Dislike" && (
                  <ThumbDownIcon htmlColor="#e91e63" />
                )}
                {/* </Container> */}
                <Typography className="review-body">
                  {item.ReviewText}
                </Typography>
                <Typography className="review-user">
                  {`${item.User.FirstName} ${item.User.LastName}`}
                </Typography>
                <Divider />
              </Container>
            );
          })}
        </Container>
      )}
    </div>
  );
};

export default ProductDetails;
