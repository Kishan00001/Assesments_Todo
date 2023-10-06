import React, { useEffect, useState } from 'react'
import { ContactService } from '../Services/ContactService'
import Contact from "../Components/Contact";
export default function ContactList(){
  const [state,setState] = useState({
    contacts:[]
  })
  //useEffect helps in performing background rendering instead of direct rendering which will pause the rendering when large data is to be rendered. It is a hook provided to perform background work while the main component doing the main rendering like loadin or validating.. 
  useEffect(()=>{
    async function getData(){
      const res = await ContactService.getAllContacts();
      setState({
        ...state,contacts:res.data
      })
    }
    getData();
  },[]);

  let {contacts} = state;
  // const contactNames = contacts.map((c)=>(<tr>{c.fullName}</tr>))
  return (
        <>
          <div className='container'>
            <div className='row'>
              {
                contacts.map((c)=><Contact contact = {c} disabled={true}/>)
              }
            </div>
          </div>
        </>
    )
}