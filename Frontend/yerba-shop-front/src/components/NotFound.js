import { Link } from "react-router-dom";
const NotFound = () => {
  return (
    <div className="not-found">
      <h2>404</h2>
      <p>Site not found</p>
      <img
        className="not-found-image"
        src="https://pbs.twimg.com/profile_images/775536744431177732/m25Chf1i_400x400.jpg"
        alt="sad_panda"
      />
      <Link className="not-found-homepage" to="/">
        Back to homepage
      </Link>
    </div>
  );
};

export default NotFound;
