<%@ Page Title="" Language="C#" MasterPageFile="~/user/user.Master" AutoEventWireup="true" CodeBehind="myProfile.aspx.cs" Inherits="PropertyManagementSystem.user.myProfile" %>
<asp:Content ID="Content1" ContentPlaceHolderID="c1" runat="server">
    <div class="col-lg-12">
                    <div class="card">
                        <div class="card-header">
                            <strong class="card-title">My Profile</strong>
                        </div>
                        <div class="card-body">
                            <asp:Repeater ID="r1" runat="server">
                                <HeaderTemplate>
                                    <table class="table">
                              <thead>
                                <tr>
                                  <th scope="col">User Id</th>
                                  <th scope="col">Username</th>
                                  <th scope="col">First Name</th>
                                  <th scope="col">Last Name</th>
                                  
                                  <th scope="col">Phone</th>
                                  
                                  
                              </tr>
                          </thead>
                                         <tbody>
                                </HeaderTemplate>
                                <ItemTemplate>
                                     <tr>
                              <td><%#Eval("id")%></td>
                              <td><%#Eval("username")%></td>
                              <td><%#Eval("fname")%></td>
                              <td><%#Eval("lname")%></td>
                              
                              <td><%#Eval("phone")%></td>
                             
                              
                          </tr>
                                </ItemTemplate>
                                <FooterTemplate>
                                     </tbody>
                  </table>
                                </FooterTemplate>
                                </asp:Repeater>
                          
                        </div>
                    </div>
                </div>

     <div class="col-lg-12">
                    <div class="card">
                        <div class="card-header">
                            <strong class="card-title">My Properties</strong>
                        </div>
                        <div class="card-body">
                            <asp:Repeater ID="r2" runat="server">
                                <HeaderTemplate>
                                    <table class="table">
                              <thead>
                                <tr>
                                  <th scope="col">Id</th>
                                  <th scope="col">Ward</th>
                                  <th scope="col">Owner</th>
                                  <th scope="col">Plot Area</th>
                                    <th scope="col">Built Area</th>
                                    <th scope="col">Use</th>
                                    <th scope="col">Occupancy</th>
                                    <th scope="col">Tax</th>
                                    <th scope="col">Edit</th>
                                  
                                  
                              </tr>
                          </thead>
                                         <tbody>
                                </HeaderTemplate>
                                <ItemTemplate>
                                     <tr>
                            
                              <td><%#Eval("id")%></td>
                              <td><%#Eval("ward")%></td>
                              <td><%#Eval("owner")%></td>
                              <td><%#Eval("size")%></td>
                              <td><%#Eval("built")%></td>
                               <td><%#Eval("type")%></td>
                              <td><%#Eval("occupancy")%></td>
                               <td><%#Eval("tax")%></td>
                              <td><a href="editUserProperty.aspx?id=<%#Eval("id")%>">Edit</a></td>
                              
                              
                          </tr>
                                </ItemTemplate>
                                <FooterTemplate>
                                     </tbody>
                  </table>
                                </FooterTemplate>
                                </asp:Repeater>
                            
                            
                         
                           
                         
                     
                        </div>
                        
                    </div>
                </div>

</asp:Content>
