import React, { Component } from 'react';

export class Home extends Component {
    static displayName = Home.name;

    constructor(props) {
        super(props);
        this.state = { numbersText: "" };
        this.formSubmit = this.formSubmit.bind(this);
        this.handleInputChange = this.handleInputChange.bind(this);
    }

    formSubmit(e) {
        e.preventDefault();
        fetch('primenumbers?numbers=' + this.state.numbersText, {
            headers: {
                'Content-Type': 'application/json',
                'Accept': 'application/json'
            }
        })
            .then(res => res.json())
            .then(resData =>
                this.setState({ numbersText: resData })
            );
    }

    handleInputChange(event) {
        const target = event.target;

        this.setState({
            numbersText: target.value
        });
    }

    render() {
        return (
            <form onSubmit={this.formSubmit}>
                <div>
                    <h1>Remove Prime Numbers</h1>
                    <p>Add in numbers below seperated by commas without spaces.</p>
                    <label>
                        <div className='col-8'>
                            <input type="text" className="form-control" placeholder="   Enter Numbers here"
                                name="numbersText" value={this.state.numbersText} onChange={this.handleInputChange} required />
                        </div>
                    </label>
                    <button className="btn btn-primary" type="submit">Remove Prime Numbers</button>
                </div>
            </form>
        );
    }
}
