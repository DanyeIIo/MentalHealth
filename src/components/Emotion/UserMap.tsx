import React from 'react';
import ReactDOM from "react-dom";
import ReactWordcloud from "react-wordcloud";

function UserMap() {

  const options = {
    colors: ["#1f77b4", "#ff7f0e", "#2ca02c", "#d62728", "#9467bd", "#8c564b"],
    enableTooltip: false,
    deterministic: false,
    fontFamily: "impact",
    fontSizes: [40, 90],
    fontStyle: "normal",
    fontWeight: "normal",
    padding: 1,
    rotations: 3,
    rotationAngles: [0, 0],
    scale: "sqrt",
    spiral: "archimedean",
    transitionDuration: 1000
  };
 const obj = {
   id:1,
   feels:[{}],
   emotions:[{text:'angry',value:10},{text:'scared',value:5},{text:'fine',value:7},{text:'void',value:13},{text:'angry',value:4},{text:'angry',value:10},{text:'scared',value:5},{text:'fine',value:7},{text:'void',value:13},{text:'angry',value:4},{text:'angry',value:10},{text:'scared',value:5},{text:'fine',value:7},{text:'void',value:13},{text:'angry',value:4}]
 }
  return (
     <div className='container-fluid'> <ReactWordcloud options={options} words={obj.emotions} /></div>
     )

}
export default UserMap