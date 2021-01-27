import React from 'react';
import Switch from 'react-bootstrap/esm/Switch';
import ReactDOM from 'react-dom';
import { HashRouter, Route } from 'react-router-dom';
import ProductExplorer from './ProductListPage/index';

ReactDOM.render(
  <React.StrictMode>
    <HashRouter>
      <Switch>
        <Route path="/">
          <ProductExplorer settings={window.initProductExplorer} />
        </Route>
      </Switch>
    </HashRouter>
  </React.StrictMode>,
  document.getElementById('root')
);
