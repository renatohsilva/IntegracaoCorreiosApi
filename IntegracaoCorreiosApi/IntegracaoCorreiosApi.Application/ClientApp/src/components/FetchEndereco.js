import React, { Component } from 'react';
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
                <div className="input-group mb-3">
                    <input type="text" className="form-control" value={this.state.cep} onChange={this.cepMudou} />
                </div>
                <button className="btn btn-primary" onClick={this.buscarEndereco}>Buscar Endereços</button>
                <div>
                    <Endereco endereco={this.state.endereco} />
                </div>
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

