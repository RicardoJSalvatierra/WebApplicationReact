import React, { Component } from 'react';

export class Titular extends Component {
  //static displayName = Titular.name;

  //constructor(props) {
  //  super(props);
  //    this.state = {
  //        titular: 0
  //    };

  //}


  render() {
    return (
      <div>
        <h1>Titular</h1>

            <p aria-live="polite">Titular: <strong>{this.props.titular}</strong></p>

      </div>
    );
  }
}
