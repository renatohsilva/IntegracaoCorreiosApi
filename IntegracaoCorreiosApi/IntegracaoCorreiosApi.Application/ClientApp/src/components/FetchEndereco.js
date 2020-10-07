import React, { Component } from 'react';
import { Row, Col } from 'reactstrap';
import { Endereco } from './/Endereco';

export class FetchEndereco extends Component {
    static displayName = FetchEndereco.name;

    constructor(props) {
        super(props);
        this.state = { endereco: null, cep: '' };
        this.cepMudou = this.cepMudou.bind(this);
        this.buscarEndereco = this.buscarEndereco.bind(this);
    }

    buscarEndereco() {
        this.carregarEndereco();
    }

    cepMudou(event) {
        this.setState({ cep: event.target.value });
    }

    render() {
        return (
            <div>
                <label>CEP</label>
                <Row>
                    <Col xs="4">
                        <input type="text" className="form-control ml-3 ml-lg-0" value={this.state.cep} onChange={this.cepMudou} />
                        <button className="btn btn-primary ml-5 ml-lg-0" onClick={this.buscarEndereco}>Buscar Endereços</button>
                    </Col>
                </Row>
                <Row>
                    <Col xs="12">
                        <Endereco endereco={this.state.endereco} />
                    </Col>
                </Row>
            </div>
        );
    }

    async carregarEndereco() {
        const encodedCep = encodeURIComponent(this.state.cep);
        const response = await fetch(`enderecopessoa?cep=${encodedCep}`);
        const data = await response.json();
        this.setState({ endereco: data });
    }
}

