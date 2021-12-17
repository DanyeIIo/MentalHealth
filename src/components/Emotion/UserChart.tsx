import React, { Component } from 'react';
import { render } from 'react-dom';
import {  Line } from 'react-chartjs-2';
import image1 from '../../../public/img/Emotion6.png'
import image2 from '../../../img/Emotion2(1).png'
import image3 from '../../../img/Emotion3(1).png'
import image4 from '../../../img/Emotion4(1).png'
import image5 from '../../../img/Emotion5(1).png'
class Chart extends Component {
  chartReference = {};
  constructor() {
    super();
    this.state = {
      name: 'React',
    };
    this.images = [image5,image4,image3,image2,image1];
    this.data = (canvas) => {
      const ctx = canvas.getContext('2d');
      const gradient = ctx.createLinearGradient(0, 0, 0, 400);
      gradient.addColorStop(0.166, '#39b54c');
      gradient.addColorStop(0.332, '#91ca61');
      gradient.addColorStop(0.5, '#fcb040');
      gradient.addColorStop(0.63, '#f25a29');
      gradient.addColorStop(0.86, '#e12025');
      return {
        labels: ["your","emotions",1,2,3,4,5,6,7,8,9,10,11,12,13,14],
        // [3, 2].concat(Array.from(
        //   {
        //     length: 14
        //     // new Date(
        //     //   new Date().getFullYear(),
        //     //   new Date().getMonth() + 1,
        //     //   0
        //     // ).getDate()+1,
        //   },
        //   (_, i) => i 
        // )),
        datasets: [
          {
            label: 'Emotion Chart',
            backgroundColor: "gradient",
            borderColor: gradient,
            pointBorderColor: gradient,
            pointBackgroundColor: gradient,
            fill: false,
            borderWidth: 2,
            data: ["one",'two',3, 2, 3, 4, 5, 1, 2, 3, 4, 5],
          },
        ],
      };
    };
  }

  componentDidMount() {
    console.log(this.chartReference.chartInstance.ctx);
  }

  render() {
    return (
        <div className='min-w-50'>
          <Line
            data={this.data}
            height={400}
            labels={this.labels}
            options={{
              tooltips: {enabled: false},
              hover: {mode: null},
              maintainAspectRatio: false,
              scales: {
                xAxes: [
                  {
                    ticks: {min:0},
                    gridLines: {
                      display: false,
                    },
                  },
                ],
                yAxes: [
                  {
                    ticks: {
                      display: false, //this will remove only the label
                      max:6,
                      min:0
                    },
                  },
                ],
              },
              legend: { display:false  }
            }}
            plugins={[{
              beforeDraw: function(c) {
              var legends = c.legend.legendItems;
              legends.forEach(function(e) {
              e.fillStyle = '#fff';
              e.borderColor = '#fff'
              });
              },
              afterDraw: chart => {      
      const ctx = chart.chart.ctx; 
      const xAxis = chart.scales['x-axis-0'];
      const yAxis = chart.scales['y-axis-0'];
      yAxis.ticks.forEach((value, index) => {  
        const y = yAxis.getPixelForTick(index);      
        const image = new Image();
        image.src = this.images[index];
      
        ctx.drawImage(image, xAxis.left, y+40);
      });      
    }}]}
            ref={(reference) => (this.chartReference = reference)}
          />
        </div>
    );
  }
}

export default Chart
