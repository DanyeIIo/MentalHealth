import React, { Component, Fragment } from 'react';
import {
  AppBar,
  Button,
  Toolbar,
  Typography,
  FormHelperText,
  FormControl,
  FormLabel,
  FormGroup,
  Checkbox,
  FormControlLabel,
  TextField,
} from '@material-ui/core';
export class Finish extends Component {
  continue = (e) => {
    e.preventDefault();
    this.props.nextStep();
  };
  back = (e) => {
    e.preventDefault();
    this.props.prevStep();
  };

  constructor() {
    super();
    this.state = {};
  }

  render() {
    const { values, handleChange, pushChange } = this.props;
    return (
      <Fragment>
        <AppBar
          style={{
            background: 'linear-gradient(45deg, #3023ae 0%, #f09 100%)',
          }}
          position="static"
        >
          <Toolbar title='What are you feeling'>
            <Typography color="inherit">What are you feeling</Typography>
          </Toolbar>
        </AppBar>
        <FormControl className="my-2" component="fieldset">
          <FormLabel  component="legend">Pick emotions</FormLabel>
          <FormGroup className="d-flex flex-row justify-content-between">
            <FormControlLabel
              className="w-25"
              control={
                <Checkbox
                  value="angry"
                  onChange={pushChange('feelings')}
                  name="angry"
                />
              }
              label="angry"
            />
            <FormControlLabel
              className="w-25"
              control={
                <Checkbox
                  value="good"
                  onChange={pushChange('feelings')}
                  name="good"
                />
              }
              label="good"
            />
            <FormControlLabel
              className="w-25"
              control={
                <Checkbox
                  value="scared"
                  onChange={pushChange('feelings')}
                  name="scared"
                />
              }
              label="Scared"
            />
            <FormControlLabel
              className="w-25"
              control={
                <Checkbox
                  value="happiness"
                  onChange={pushChange('feelings')}
                  name="happiness"
                />
              }
              label="happiness"
            />
            <FormControlLabel
              className="w-25"
              control={
                <Checkbox
                  value="surprise"
                  onChange={pushChange('feelings')}
                  name="surprise"
                />
              }
              label="surprise"
            />
            <FormControlLabel
              className="w-25"
              control={
                <Checkbox
                  value="good"
                  onChange={pushChange('feelings')}
                  name="good"
                />
              }
              label="good"
            />
            {/* <FormControlLabel
           className="w-25"
            control={
              <Checkbox
                value="angry"
                onChange={pushChange("feelings")}
                name="angry"
              />
            }
            label="angry"
          />
          <FormControlLabel
          className="w-25"
            control={
              <Checkbox
                value="good"
                onChange={pushChange("feelings")}
                name="good"
              />
            }
            label="good"
          />
          <FormControlLabel
          className="w-25"
            control={
              <Checkbox
                value="scared"
                onChange={pushChange("feelings")}
                name="scared"
              />
            }
            label="Scared"
          />
           <FormControlLabel
           className="w-25"
            control={
              <Checkbox
                value="happiness"
                onChange={pushChange("feelings")}
                name="happiness"
              />
            }
            label="happiness"
          />
           <FormControlLabel
           className="w-25"
            control={
              <Checkbox
                value="surprise"
                onChange={pushChange("feelings")}
                name="surprise"
              />
            }
            label="surprise"
          />
           <FormControlLabel
           className="w-25"
            control={
              <Checkbox
                value="good"
                onChange={pushChange("feelings")}
                name="good"
              />
            }
            label="good"
          /> */}
            <TextField
              id="outlined-helperText"
              label="Write your own here!"
              defaultValue={values.extrafeellings}
              onChange={handleChange('extrafeellings')}
              helperText="You could write several using comma"
            />
          </FormGroup>

          <FormHelperText>You can choose several feelings.</FormHelperText>
        </FormControl>

        
        <div  className="text-center d-flex justify-content-center my-2">
        {/* <Button
          style={{
            background: '#EE3B55',
            color: '#FFFFFF',
            marginRight: '1em',
          }}
          label="Continue"
          onClick={this.back}
        >
          Back
        </Button> */}
        <Button
          style={{
            background: 'linear-gradient(45deg, #3023ae 0%, #f09 100%)',
            color: '#FFFFFF',
            marginRight: '1em',
          }}
          label="Continue"
          onClick={this.continue}
        >
          Confirm and Continue
        </Button>
        </div>
      </Fragment>
    );
  }
}

export default Finish;
