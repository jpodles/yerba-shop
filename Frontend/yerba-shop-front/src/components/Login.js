import React, { useState } from "react";
import Button from "@material-ui/core/Button";
import SendIcon from "@material-ui/icons/Send";

const Login = ({ Log, error }) => {
  const [details, setDetails] = useState({ name: "", email: "", password: "" });

  const submitHandler = (e) => {
    e.preventDefault();
    Log(details);
  };

  return (
    <form onSubmit={submitHandler} className="login-form">
      <div className="form-inner">
        <h2>Login</h2>
        {error !== "" ? <div className="error">{error}</div> : ""}
        <div className="form-group">
          <label htmlFor="name">Name:</label>
          <input
            type="text"
            name="name"
            id="name"
            onChange={(e) => setDetails({ ...details, name: e.target.value })}
            value={details.name}
          />
        </div>
        <div className="form-group">
          <label htmlFor="email">Email:</label>
          <input
            type="text"
            className="email"
            id="email"
            onChange={(e) => setDetails({ ...details, email: e.target.value })}
            value={details.email}
          />
        </div>
        <div className="form-group">
          <label htmlFor="password">Password:</label>
          <input
            type="password"
            className="password"
            id="password"
            onChange={(e) =>
              setDetails({ ...details, password: e.target.value })
            }
            value={details.password}
          />
        </div>
        <Button
          type="submit"
          value="LOGIN"
          variant="contained"
          color="primary"
          endIcon={<SendIcon />}
        >
          LOGIN
        </Button>
      </div>
    </form>
  );
};

export default Login;
