import React, { useState, useEffect } from 'react';
// import '../App.css';
import UserForm from './Form';
import UserMap from './UserMap';
import Chart from './UserChart';
function Emotion() {
  return (
    <div className="my-3">
      <div className="conteiner-fluid d-flex align-items-center flex-column mt-5">
        <UserMap />
      </div>
      <div className="container-fluid align-items-center justify-content-between d-flex flex-column flex-lg-row  flex-sm-column">
        <div className="mx-5 w-50 bg-white">
          <UserForm />
        </div>
        <div className="mw-50 w-75 my-5">
          <Chart />
        </div>
      </div>
    </div>
  );
}

export default Emotion;
