import React, { Component} from 'react';

export class FetchData extends Component {
    static displayName = FetchData.name;

  constructor(props) {
    super(props);
      this.state = { items: [], loading: true, };
  }

  componentDidMount() {
    this.populateWeatherData();
    }


    static renderForecastsTable(items) {

        function refreshAPI(e, body) {
            e.preventDefault();
            alert(body);
        }

      return (
      <table className='table table-striped' aria-labelledby="tabelLabel">
        <thead>
           <tr>
            <th>Buttons</th>
            <th>Id</th>
            <th>Title</th>
            <th>Body</th>
          </tr>
        </thead>
        <tbody>
                  {items.map(item =>
                      <tr key={item.userId}>
                          <td>
                              {/*<button key={item.id} onClick={(e) => this.refreshAPI(e, item.body)}>Button {item.id}</button>*/}
                              <button onClick={(e) => refreshAPI(e, item.body)}>Open</button>
                          </td>
              <td>{item.id}</td>
              <td>{item.title}</td>
              <td>{item.body}</td>
                      </tr>
                  )}
                    
           
        </tbody>
      </table>
    );
  }

  render() {
      let contents = this.state.loading
      ? <p><em>Loading...</em></p>
          : FetchData.renderForecastsTable(this.state.items);   

    return (
      <div>
        <h1 id="tabelLabel" >Json Comments</h1>
            <p>This component returns data from an API.</p>
            {/*    <label>Enter the query information for the JsonPlaceholder API: </label><br></br>*/}
            {/*    <input type="text" id="textbox"></input><br></br>*/}
            {/*<p id="message"></p>*/}
            {contents}
      </div>
    );
  }

  async populateWeatherData() {
    const response = await fetch('item');
          
      const data = await response.json();
    this.setState({ items: data, loading: false });
  }
}
