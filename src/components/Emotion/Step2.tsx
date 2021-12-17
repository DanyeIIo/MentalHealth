import React, { Component, Fragment } from "react";
import {
  AppBar,
  Button,
  TextField,
  Toolbar,
  Typography,
  TextareaAutosize
} from "@material-ui/core";

export class FormPersonalDetails extends Component {
  continue = e => {
    e.preventDefault();
    this.props.nextStep();
  };
  back = e => {
    e.preventDefault();
    this.props.prevStep();
  };
  constructor() {
    super();
    this.state = {};
  }

  render() {
    const { values, handleChange } = this.props;
    return (
      <Fragment>
        <AppBar style={{ background: "linear-gradient(45deg, #3023ae 0%, #f09 100%)" }} position="static">
          <Toolbar title="Describe your emotions">
          <br/>
          <br/>
            <Typography color="inherit">
            { Number(new Date().toLocaleTimeString('en-US', { hour12: false, 
            hour: "numeric", 
            minute: "numeric"}).split(':')[0])<15? "How was u sleep": "What your strongest emotion"}
            </Typography>
          </Toolbar>
        </AppBar>
        <TextareaAutosize
  aria-label="Emotion description"
  placeholder="  Write some sentences"
  minRows={10}
  className="w-100 text-left "
  onChange={handleChange("description")}
/>
        <div  className="text-center d-flex justify-content-center my-2">
        {/* <Button
          style={{
            background: "#EE3B55",
            color: "#FFFFFF",
            marginRight: "1em"
          }}
          label="Back"
          onClick={this.back}
        >
          Back
        </Button> */}
        <Button
          style={{
            background: "linear-gradient(45deg, #3023ae 0%, #f09 100%)",
            color: "#FFFFFF"
          }}
          label="Continue"
          onClick={this.continue}
        >
          {" "}
          Continue
        </Button>
        </div>
      </Fragment>
    );
  }
}

export default FormPersonalDetails;
