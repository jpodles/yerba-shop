import { Link } from "react-router-dom";
import Button from "@material-ui/core/Button";
import ButtonGroup from "@material-ui/core/ButtonGroup";

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
        <ButtonGroup variant="contained" color="primary" size="large">
          <Button>
            <Link to="/">Home</Link>
          </Button>
          <Button>
            <Link to="/login">Zaloguj się</Link>
          </Button>
        </ButtonGroup>

        {/* <div className="logowanie">
          <Link to="/login">
            <p>Zaloguj się</p>
          </Link>
        </div> */}
      </div>
    </nav>
  );
};

export default Navbar;
