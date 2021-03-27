import { useParams } from "react-router";
import useFetch from "../fetch_api/useFetch";

const ProductDetails = () => {
  const { id } = useParams();
  const { data: product, error, isPending } = useFetch(
    "http://localhost:8000/products/" + id
  );

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
          </div>
        </div>
      )}
    </div>
  );
};

export default ProductDetails;
