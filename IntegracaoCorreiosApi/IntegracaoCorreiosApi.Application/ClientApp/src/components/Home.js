import React, { Component } from 'react';

export class Home extends Component {
  static displayName = Home.name;

  render () {
    return (
        <div>
            <label>Projeto feito a título de estudo, demonstrando como é possível fazer a integração com os Correios.</label>
            <label>O web service utilizado na integração é o web service do SIGEP. Este web service possui diversos métodos.</label>
            <label>O que é demonstrado neste exemplo é o método que retorna o endereço correspondente a um CEP.</label>
            <label>O endereço do web service do SIGEP é o seguinte:</label>
            https://apps.correios.com.br/SigepMasterJPA/AtendeClienteService/AtendeCliente?wsdl
        </div>
    );
  }
}
