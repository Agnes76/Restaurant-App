import React from 'react';
import './App.css';
import { Container, Typography } from '@mui/material';
import Order from "./components/Order/index.js"

function App() {
  return (
    <Container maxWidth="md">
      <Typography
      gutterBottom
        variant="h4"
        align="left">Restaurant App</Typography>
        <Order />
    </Container>
  );
}

export default App;
