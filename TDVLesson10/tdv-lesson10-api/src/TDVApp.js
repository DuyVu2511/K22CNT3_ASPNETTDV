import './App.css';
import TDVListUsers from './components/TDVListUsers';
import axios from './api/TDVApi'
import { useEffect, useState } from 'react';

function TDVApp() {

  const [tdvListUsers,setTDVListUsers] = useState([]);

  //doc du lieu tu api
  const tdvGetAllUser = async ()=>{
    const tdvResponse = await axios.get("tdvUsers");
    console.log("Api Data:",tdvResponse.data);
    setTDVListUsers(tdvResponse.data)
  }

  useEffect(()=>{
    tdvGetAllUser();
    console.log("State Data:",tdvListUsers);
  },[])

  return (
    <div className="container border my-3">
      <h1>Lam viec voi MockApi</h1>
      <hr/>
      <TDVListUsers renderTDVListUsers={tdvListUsers}/>
    </div>
  );
}

export default TDVApp;
