import React, {useState} from 'react'
import Form from "../../layouts/Form";
import {Grid, InputAdornment, makeStyles, TextareaAutosize, ButtonGroup, Button as MuiButton} from "@material-ui/core";
import {Input, Select, Button} from '../controls/index';
import ReplayIcon from '@material-ui/icons/Replay';
import RestaurantMenuIcon from '@material-ui/icons/RestaurantMenu';
import ReorderIcon from '@material-ui/icons/Reorder'
import { useForm } from '../hooks/useForm';


const PaymentMethods = [
    {id:'none', title:'Select'},
    {id:'Cash', title:'Cash'},
    {id:'Card', title:'Card'}
]



const useStyles = makeStyles(theme =>({
    adornmentText :{
        '& .MuiTypography-root': {
            color: '#f3b33d',
            fontWeight: 'bolder',
            fontSize: '1.5em'
        }
    },
    submitButtonGroup: {
        backgroundColor: 'DodgerBlue',
        color: '#000',
        margin: theme.spacing(1),
        '& .MuiButton-label': {
            textTransform: 'none'
        },
        '&:hover': {
            backgroundColor: 'DodgerBlue'
        }
    }
}))


export default function OrderForm(props) {

    const {values, errors, handleInputChange} = props;

   const classes = useStyles

    return (   
        <>

       <Form >
       <Grid container spacing={1}>
           <Grid item xs = {6}>
            <Input
            disabled
            label="Order Number"
            name="orderNumber"
            value={values.orderNumber}
            InputProps ={{
                startAdornment : <InputAdornment
                className='classes.adornmentText'
                position="start">#</InputAdornment> 
            }}
            />
            <Select
            label="Customer"
            name="customerId"
            onChange={handleInputChange}
            value={values.customerId}
            options={[
                {id:0, title: 'Select'},
                {id:1, title: 'Customer 1'},
                {id:2, title: 'Customer 2'},
                {id:3, title: 'Customer 3'},
                {id:4, title: 'Customer 4'}
            ]}

            />
           </Grid> 

           <Grid item xs = {6}>
           <Input
            disabled
            label="GTotal"
            name="gTotal"
            value={values.gTotal}
            InputProps ={{
                startAdornment : <InputAdornment
                className='classes.adornmentText'
                position="start">$</InputAdornment> 
            }}
            />
             <Select
            label="Payment Method"
            name="PaymentMethod"
            onChange={handleInputChange}
            options={PaymentMethods}
            value={values.PaymentMethod}
            />
           
               </Grid>   
            <Grid item xs ={12}>
             
            <ButtonGroup className = 'classes.submitButtonGroup'>
            <MuiButton
            size="large"
            align="center"
            endIcon={<RestaurantMenuIcon />}
            type="submit">Submit</MuiButton>
            <MuiButton
            size="small"
            startIcon={<ReplayIcon />}
            / >
            </ButtonGroup>
            <Button
            size="large"
            startIcon={<ReorderIcon />}
            >Orders</Button>
     </Grid>

            </Grid>
            
       </Form>

    </>
    
    )
}
