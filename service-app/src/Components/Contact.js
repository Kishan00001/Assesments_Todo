import React,{useEffect, useState} from 'react'
import ImageComponent from './ImageComponent'
import Navigation from './Navigation'
import { ContactService } from '../Services/ContactService';
import { useNavigate } from 'react-router-dom';

export default function Contact({contact,disabled}) {
    let navigate = useNavigate();
    console.log({contact,disabled});
    const [currCont, setCurrCont] = useState({...contact})
    useEffect(()=>{setCurrCont(contact)},[contact]);
    console.log(currCont);
    const onUpdateInput = (ev) =>{
        const {name,value} = ev.target;
        setCurrCont({...currCont, [name] : value})
    }

    // onUpdate with then and catch
    const onUpdate = (ev) =>{
        ContactService.updateContact(currCont).then(data=>{
            alert("Data is updated");
            navigate("/");
            // <Navigate to={'/contacts/list'}/>
        }).catch(err=>alert(err.message))
    }

    // onUpdate with async-await
    // const onUpdateAsyncAwait = async (ev) =>{
    //     const res = await ContactService.updateContact(currCont);
    //     console.log(JSON.stringify(res.data));
    //     alert("Data is updated");
    //     navigate("/")
    // }
    return(
        <div className='col-md-5 m-2 bg-light'>
        <pre>{JSON.stringify(contact)}</pre>
        <div className="container">
            <div className="row">
                <div className="col-md-4">
                    <ImageComponent url={"/images/" + currCont.image}/>
                </div>
                <div className="col-md-6">
                    <input type='text'disabled={disabled} name='id' onChange={onUpdateInput} className='form-control m-2' placeholder='ContactID' value={currCont.id}/>
                    <input type='text'disabled={disabled} name='fullName' onChange={onUpdateInput} className='form-control m-2' placeholder='Contact Name' value={currCont.fullName}/>
                    <input type='text'disabled={disabled} name='emailAddress' onChange={onUpdateInput} className='form-control m-2' placeholder='Contact Email' value={currCont.emailAddress}/>
                    <input type='text'disabled={disabled} name='phoneNo' onChange={onUpdateInput} className='form-control m-2' placeholder='Contact Phone' value={currCont.phoneNo}/>
                </div>
                <div className="col-md-2">
                    <Navigation id={contact.id}/>
                </div>
            </div>
            <div>
                <button className='btn btn-primary' onClick={onUpdate} disabled={disabled}>Update</button>
            </div>
        </div>
    </div>
  )
}