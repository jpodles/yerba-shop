import { BrowserRouter as Router, Route, Switch } from "react-router-dom";
import Footer from "./components/Footer";
import Home from "./components/Home";
import Navbar from "./components/Navbar";
import NotFound from "./components/NotFound";
import ProductDetails from "./components/ProductDetails";
import Login from "./components/Login";
import "./index.scss";
import React, { useState } from "react";
import { createMuiTheme, ThemeProvider } from "@material-ui/core/styles";

function App() {
  const adminUser = {
    email: "admin@admin.com",
    password: "admin123",
  };

  const theme = createMuiTheme({
    palette: {
      primary: {
        main: "#88b451",
        contrastText: "#fff",
      },
      secondary: {
        main: "#d1ccb2",
        contrastText: "#333",
      },
    },
    typography: {
      fontFamily: "Roboto Slab",
    },
  });

  const [user, setUser] = useState({ name: "", email: "" });
  const [error, setError] = useState("");

  const Log = (details) => {
    console.log(details);

    if (
      details.email === adminUser.email &&
      details.password === adminUser.password
    ) {
      console.log("logged in");
      setUser({
        name: details.name,
        email: details.email,
      });
    } else {
      console.log("Details do not match!");
      setError("Details do not match!");
    }
  };

  const Logout = () => {
    setUser({ name: "", email: "" });
  };

  return (
    <ThemeProvider theme={theme}>
      <Router>
        <div className="App">
          <Navbar />
          <div className="content">
            <Switch>
              <Route exact path="/">
                <Home />
              </Route>
              <Route path="/products/:id">
                <ProductDetails />
              </Route>
              <Route path="/login">
                <div className="app">
                  {user.email !== "" ? (
                    <div className="welcome">
                      <h2>
                        Welcome, <span>{user.name}</span>
                      </h2>
                      <button onClick={Logout}>Logout</button>
                    </div>
                  ) : (
                    <Login Log={Log} error={error} />
                  )}
                </div>
              </Route>
              <Route path="*">
                <NotFound />
              </Route>
            </Switch>
          </div>
          <Footer />
        </div>
      </Router>
    </ThemeProvider>
  );
}

export default App;
