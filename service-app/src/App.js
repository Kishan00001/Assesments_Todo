import ContactList from "./Components/ContactList";
import AddContact from "./Components/AddContact";
import EditContact from "./Components/EditContact";
import NavBar from "./Components/NavBar";
import ViewContact from "./Components/ViewContact"
// import {Navigate,Route,Routes} from "react-router-dom";
import {Navigate, Route, Routes} from 'react-router-dom'
import './App.css';

function App() {
  return (
    <div className="App">
     <NavBar/>
      <Routes>
        <Route path = {'/'} element = { <Navigate to={'/contacts/list'}/>}/> 
        <Route path = {'/contacts/list'} element = { <ContactList/>}/> 
        <Route path = {'/contacts/add'} element = { <AddContact/>}/> 
        <Route path={'/contacts/edit/:contactId'} element={<EditContact/>}/>
        <Route path={'/contacts/view/:contactId'} element={<ViewContact/>}/>
        <Route path={'/contacts/delete/:contactId'} element={<ContactList/>}/>
      </Routes>
    </div>
  );
}

export default App;