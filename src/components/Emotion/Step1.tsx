import React, { Component, Fragment } from 'react';
import {
  AppBar,
  Button,
  TextField,
  Toolbar,
  Typography,
  RadioGroup,
  Radio,
  FormControlLabel,
} from '@material-ui/core';
import axios from 'axios';

export class FormUserDetails extends Component {
  continue = (e) => {
    e.preventDefault();
    this.props.nextStep();
  };

  constructor() {
    super();
    this.state = {};
  }

  render() {
    const { values, handleChange } = this.props;
    // fetch('https://mentalhealthapi2.azurewebsites.net/Account/register',{
    //   method: 'POST',
    //   headers: { 'Content-Type': 'application/json' },
    //   body: {
    //     "email": "stringasdasdasazxc@list.ru",
    //     "birthDate": "2011-12-15T17:34:43.513Z",
    //     "jobTitle": "striasdasng",
    //     "password": "striasdngstringstring"
    //   }
    // })
    // .then(response => console.log(response))
    // .then(data => console.log(data));
    // "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJodHRwOi8vc2NoZW1hcy54bWxzb2FwLm9yZy93cy8yMDA1LzA1L2lkZW50aXR5L2NsYWltcy9uYW1laWRlbnRpZmllciI6IjA0YjQzMTI3LTdiYmUtNGYzMi1hZWNlLTRiYmIwYTI2ZWRjNSIsImh0dHA6Ly9zY2hlbWFzLnhtbHNvYXAub3JnL3dzLzIwMDUvMDUvaWRlbnRpdHkvY2xhaW1zL25hbWUiOiJERFpYQ0BsaXN0LnJ1IiwiaHR0cDovL3NjaGVtYXMubWljcm9zb2Z0LmNvbS93cy8yMDA4LzA2L2lkZW50aXR5L2NsYWltcy9yb2xlIjpbIlVzZXIiLCI3NWFkM2RjYS0zZWRhLTQwODYtODY3Mi05OTJhMjYwMTZhNjgiXSwibmJmIjoxNjM5Njk1MzQ4LCJleHAiOjE2Mzk3ODE3NDgsImlzcyI6Imh0dHBzOi8vbWVudGFsaGVhbHRoYXBpMi5henVyZXdlYnNpdGVzLm5ldCIsImF1ZCI6Imh0dHBzOi8vbWVudGFsaGVhbHRoYXBpMi5henVyZXdlYnNpdGVzLm5ldCJ9.rN76t1AMz5iIG5AI-fbijC4t8BG_3HMS8v7orX2BfCA"
    // "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJodHRwOi8vc2NoZW1hcy54bWxzb2FwLm9yZy93cy8yMDA1LzA1L2lkZW50aXR5L2NsYWltcy9uYW1laWRlbnRpZmllciI6IjA0YjQzMTI3LTdiYmUtNGYzMi1hZWNlLTRiYmIwYTI2ZWRjNSIsImh0dHA6Ly9zY2hlbWFzLnhtbHNvYXAub3JnL3dzLzIwMDUvMDUvaWRlbnRpdHkvY2xhaW1zL25hbWUiOiJERFpYQ0BsaXN0LnJ1IiwiaHR0cDovL3NjaGVtYXMubWljcm9zb2Z0LmNvbS93cy8yMDA4LzA2L2lkZW50aXR5L2NsYWltcy9yb2xlIjpbIlVzZXIiLCI3NWFkM2RjYS0zZWRhLTQwODYtODY3Mi05OTJhMjYwMTZhNjgiXSwibmJmIjoxNjM5Njk1Mzg3LCJleHAiOjE2Mzk3ODE3ODcsImlzcyI6Imh0dHBzOi8vbWVudGFsaGVhbHRoYXBpMi5henVyZXdlYnNpdGVzLm5ldCIsImF1ZCI6Imh0dHBzOi8vbWVudGFsaGVhbHRoYXBpMi5henVyZXdlYnNpdGVzLm5ldCJ9.2UxL36E8enhLHT4Sr68cQ5f9AoX7qvbK2mnzn4zJYW4"
    // axios
    //   .get('https://mentalhealthapi20211217041136.azurewebsites.net/Account/TestResult/GetUserTestResultsLast30days/3bc0883c-cb05-41e0-bd3c-78fe675cf0d1', {
    //     headers: { Authorization: `Bearer eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJodHRwOi8vc2NoZW1hcy54bWxzb2FwLm9yZy93cy8yMDA1LzA1L2lkZW50aXR5L2NsYWltcy9uYW1laWRlbnRpZmllciI6IjNiYzA4ODNjLWNiMDUtNDFlMC1iZDNjLTc4ZmU2NzVjZjBkMSIsImh0dHA6Ly9zY2hlbWFzLnhtbHNvYXAub3JnL3dzLzIwMDUvMDUvaWRlbnRpdHkvY2xhaW1zL25hbWUiOiJzdHJzaW5nYXNkYXN6eGNhZGFhYWFzYXNhenhhc2NAbWFpbC5ydSIsImh0dHA6Ly9zY2hlbWFzLm1pY3Jvc29mdC5jb20vd3MvMjAwOC8wNi9pZGVudGl0eS9jbGFpbXMvcm9sZSI6WyJVc2VyIiwiNzVhZDNkY2EtM2VkYS00MDg2LTg2NzItOTkyYTI2MDE2YTY4Il0sIm5iZiI6MTYzOTY5NTIxMCwiZXhwIjoxNjM5NzgxNjEwLCJpc3MiOiJodHRwczovL21lbnRhbGhlYWx0aGFwaTIuYXp1cmV3ZWJzaXRlcy5uZXQiLCJhdWQiOiJodHRwczovL21lbnRhbGhlYWx0aGFwaTIuYXp1cmV3ZWJzaXRlcy5uZXQifQ.Q7pnrbu5PrB6qGSz1_GsqO3lH-Q4xlHH1zP9Uk8K6pA`}
    //   })
    //   .then((response) => console.log(response.data))
    //   .catch((err) => console.log(err));
    // axios
    //   .get(
    //     'https://mentalhealthapi20211217041136.azurewebsites.net/Account​/TestResult​/GetUserTestResultsLast30days​/00949167-eaba-4db2-b9b1-0711059793c8',
    //     {
    //       headers: {
    //         Authorization: `Bearer eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJodHRwOi8vc2NoZW1hcy54bWxzb2FwLm9yZy93cy8yMDA1LzA1L2lkZW50aXR5L2NsYWltcy9uYW1laWRlbnRpZmllciI6IjAwOTQ5MTY3LWVhYmEtNGRiMi1iOWIxLTA3MTEwNTk3OTNjOCIsImh0dHA6Ly9zY2hlbWFzLnhtbHNvYXAub3JnL3dzLzIwMDUvMDUvaWRlbnRpdHkvY2xhaW1zL25hbWUiOiJzdHJzaW5nYXNkYXN6eGNhZGFhYWFzYXNhenhjQG1haWwucnUiLCJodHRwOi8vc2NoZW1hcy5taWNyb3NvZnQuY29tL3dzLzIwMDgvMDYvaWRlbnRpdHkvY2xhaW1zL3JvbGUiOlsiVXNlciIsIjc1YWQzZGNhLTNlZGEtNDA4Ni04NjcyLTk5MmEyNjAxNmE2OCJdLCJuYmYiOjE2Mzk2OTM5NjEsImV4cCI6MTY0MDI5ODc2MSwiaXNzIjoiaHR0cHM6Ly9sb2NhbGhvc3Q6NTAwMCIsImF1ZCI6Imh0dHBzOi8vbG9jYWxob3N0OjUwMDAifQ.ObX433Z_gt2cDdcNxmbwS7ctuM1t2dlUKUIIPt70DmM`,
    //       },
    //     }
    //   )
    //   .then((response) => console.log(response.data))
    //   .catch((err) => console.log(err));
    // axios
    //   .post('https://mentalhealthapi2.azurewebsites.net/Account/me/', {

    //   })
    //   .then((response) => console.log(response.data))
    //   .catch((err) => console.log(err));
    return (
      <Fragment>
        <AppBar
          style={{
            background: 'linear-gradient(45deg, #3023ae 0%, #f09 100%)',
          }}
          position="static"
        >
          <Toolbar title="How are u">
            <Typography color="inherit">How are u</Typography>
          </Toolbar>
        </AppBar>
        <RadioGroup
          className="d-flex-column allign-items-center"
          aria-label="emotion"
          name="radio-buttons-group"
        >
          <FormControlLabel
            className="d-flex shadow-sm  mx-0 my-2 justify-content-start"
            onChange={handleChange('emotion')}
            value="5"
            control={<Radio />}
            label={<h2 style={{ color: '#39b54c' }}>Fine</h2>}
          />
          <FormControlLabel
            className="d-flex shadow-sm mx-0 my-2 justify-content-start"
            onChange={handleChange('emotion')}
            value="4"
            control={<Radio />}
            label={<h2 style={{ color: '#91ca61' }}>Good</h2>}
          />
          <FormControlLabel
            className="d-flex shadow-sm mx-0 my-2 justify-content-start"
            onChange={handleChange('emotion')}
            value="3"
            control={<Radio />}
            label={<h2 style={{ color: '#fcb040' }}>Normal</h2>}
          />
          <FormControlLabel
            className="d-flex shadow-sm mx-0 my-2 justify-content-start"
            onChange={handleChange('emotion')}
            value="2"
            control={<Radio />}
            label={<h2 style={{ color: '#f25a29' }}>So-so</h2>}
          />
          <FormControlLabel
            className="d-flex mx-0 my-2 shadow-sm justify-content-start"
            onChange={handleChange('emotion')}
            value="1"
            control={<Radio />}
            label={<h2 style={{ color: '#e12025' }}>Bad</h2>}
          />
        </RadioGroup>
<div  className="text-center d-flex justify-content-center py-2 "><Button
         
          style={{
            background: 'linear-gradient(45deg, #3023ae 0%, #f09 100%)',
            color: '#FFFFFF',
          }}
          label="Continue"
          onClick={this.continue}
        >
          Continue
        </Button></div>
        
      </Fragment>
    );
  }
}

export default FormUserDetails;
