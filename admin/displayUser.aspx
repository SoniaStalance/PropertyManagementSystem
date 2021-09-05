<%@ Page Title="" Language="C#" MasterPageFile="~/admin/admin.Master" AutoEventWireup="true" CodeBehind="displayUser.aspx.cs" Inherits="PropertyManagementSystem.admin.displayUser" %>
<asp:Content ID="Content1" ContentPlaceHolderID="c1" runat="server">
    <div class="col-lg-12">
                    <div class="card">
                        <div class="card-header">
                            <strong class="card-title">Users Information</strong>
                        </div>
                        <div class="card-body">
                            <asp:Repeater ID="r1" runat="server">
                                <HeaderTemplate>
                                    <table class="table">
                              <thead>
                                <tr>
                                  <th scope="col">User Id</th>
                                  <th scope="col">First Name</th>
                                  <th scope="col">Last Name</th>
                                  
                                  <th scope="col">Phone</th>
                                  <th scope="col">Delete</th>
                                  
                              </tr>
                          </thead>
                                         <tbody>
                                </HeaderTemplate>
                                <ItemTemplate>
                                     <tr>
                              <td><%#Eval("id")%></td>
                              <td><%#Eval("fname")%></td>
                              <td><%#Eval("lname")%></td>
                              
                              <td><%#Eval("phone")%></td>
                              <td><a href="delUser.aspx?id=<%#Eval("id")%>">Delete</a></td>
                              
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
