import { Link } from "react-router-dom";

const Navbar = () => {
  return (
    <nav className="navbar">
      <Link to="/" className="logo">
        <img
          src="https://img2.apksum.com/8f/co.tapcart.app.id_Ft2TYDAdfq/1.21.9/icon.png"
          alt="icon"
        />
        {"Yerba Mate!"}
      </Link>
      <div className="links">
        <Link to="/">Home</Link>
      </div>
    </nav>
  );
};

export default Navbar;
