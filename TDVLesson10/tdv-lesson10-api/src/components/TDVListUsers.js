import React from 'react'

export default function TDVListUsers({renderTDVListUsers}) {
    console.log("TDVListUsers:",renderTDVListUsers);
    // hien thi du lieu
    let tdvElementUsers = renderTDVListUsers.map((tdvUser,index)=>{
        return(
            <>
                 <tr>
                    <td>{tdvUser.TDVid}</td>
                    <td>{tdvUser.TDVUserName}</td>
                    <td>{tdvUser.TDVPassword}</td>
                    <td>{tdvUser.TDVEmail}</td>
                    <td>{tdvUser.TDVPhone}</td>
                    <td>...</td>
                </tr>
            </>
        )
    })
  return (
    <div className='row'>
        <div className='col-md-12'>
            <table className='table table-bordered'>
                <thead>
                    <tr>
                        <th>Id</th>
                        <th>UserName</th>
                        <th>Password</th>
                        <th>Email</th>
                        <th>Phone</th>
                        <th>Chuc nang</th>
                    </tr>
                </thead>
                <tbody>
                    {tdvElementUsers}
                </tbody>
            </table>
        </div>
    </div>
  )
}
