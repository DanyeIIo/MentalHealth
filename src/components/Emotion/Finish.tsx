import React, { Component, Fragment } from "react";
import {
  AppBar,
  Toolbar,
  Typography,
  Button,
  MuiThemeProvider
} from "@material-ui/core";

export class Success extends Component {
  first = e => {
    setTimeout(() => {
      this.props.firstStep();
    }, 1000);
  };
  render() {
    return (
      <MuiThemeProvider>
        <AppBar style={{ background: "#77E976" }} position="sticky">
          <Toolbar title="Enter Personal Information">
            <Typography color="inherit" variant="title">
              Confirm Details
            </Typography>
          </Toolbar>
        </AppBar>
        <br />
        <Typography variant="title">Thank you for your submission!</Typography>
        <br />
        <Typography>You will get an alert if something goes wrong</Typography>
        <br/>
        <br/>
        {/* <Button
          style={{ background: "#2E3B55", color: "#FFFFFF" }}
          onClick={this.first}
        >
          To First
        </Button> */}
      </MuiThemeProvider>
    );
  }
}

export default Success;
