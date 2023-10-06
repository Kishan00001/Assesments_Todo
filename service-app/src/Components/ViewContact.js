import React, { useEffect, useState } from 'react'
import {useParams} from 'react-router-dom';
import { ContactService } from '../Services/ContactService';
import Contact from './Contact';
const ViewContact = () => {
    let {contactId} = useParams();
    let[state,setState] = useState({selected:{}})
    let {selected} = state;
    useEffect(()=>{
        async function getContact(){
            console.log(contactId);
            let res = await ContactService.getContact(contactId);
            setState({selected:res.data});
        }
        getContact();
    },[contactId]);
    return (
    <div className='container'>
        <Contact contact = {selected} disabled={true}/>
    </div>
  )
}

export default ViewContact;