import React, { Component } from 'react';

export class Endereco extends Component {

    montarendereco(endereco) {
        if (endereco) {
            return (
                <div>
                    <label>Endereço</label>
                    <div className="input-group mb-3">
                        <input type="text" className="form-control" value={endereco.endereco} readOnly={true} />
                    </div>
                    <label>Complemento</label>
                    <div className="input-group mb-3">
                        <input type="text" className="form-control" value={endereco.complemento2} readOnly={true} />
                    </div>
                    <label>Bairro</label>
                    <div className="input-group mb-3">
                        <input type="text" className="form-control" value={endereco.bairro} readOnly={true} />
                    </div>
                    <label>Cidade</label>
                    <div className="input-group mb-3">
                        <input type="text" className="form-control" value={endereco.cidade} readOnly={true} />
                    </div>
                    <label>UF</label>
                    <div className="input-group mb-3">
                        <input type="text" className="form-control" value={endereco.uf} readOnly={true} />
                    </div>
                </div>
            );
        }
        return (<div></div>);   
    }

    render() {
        return this.montarendereco(this.props.endereco);
    }
}
