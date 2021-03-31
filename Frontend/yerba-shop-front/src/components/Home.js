import useFetch from "../fetch_api/useFetch";
import ProductList from "./ProductList";

const Home = () => {
  const { data: products, isPending, error } = useFetch(
    "http://localhost:8000/products"
  );

  return (
    <div className="home">
      {isPending && <div className="load">Loading...</div>}
      {error && <div> {error} </div>}
      {products && <ProductList products={products} />}
    </div>
  );
};

export default Home;
