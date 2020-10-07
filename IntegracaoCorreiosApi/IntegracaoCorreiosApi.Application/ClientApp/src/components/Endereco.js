import React, { Component } from 'react';
import { Table } from 'reactstrap';

export class Endereco extends Component {

    montarendereco(endereco) {
        if (endereco) {
            return (
                <Table>
                    <thead>
                        <tr>
                            <th>Endereço</th>
                            <th>Complemento</th>
                            <th>Bairro</th>
                            <th>Cidade</th>
                            <th>UF</th>
                        </tr>
                    </thead>
                    <tbody>
                        <tr>
                            <td>{endereco.logradouro}</td>
                            <td>{endereco.complemento}</td>
                            <td>{endereco.bairro}</td>
                            <td>{endereco.localidade}</td>
                            <td>{endereco.uf}</td>
                        </tr>
                    </tbody>
                </Table>
            );
        }
        return (<div></div>);   
    }

    render() {
        return this.montarendereco(this.props.endereco);
    }
}
