import { Link } from "react-router-dom";

const ProductList = ({ products }) => {
  return (
    <div className="product-list">
      {products.map((product) => (
        <Link to={`/products/${product.id}`}>
          <div className="blog-prev" key={product.id}>
            <h2>{product.ProductName}</h2>
            <img src={product.ImageLink} alt="ProductImage" />
            <div className="desc">{product.ShortDescription}</div>
            <div className="price">{product.ProductPrice} zł</div>
          </div>
        </Link>
      ))}
    </div>
  );
};

export default ProductList;
