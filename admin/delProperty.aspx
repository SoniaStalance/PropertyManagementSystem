<%@ Page Title="" Language="C#" MasterPageFile="~/admin/admin.Master" AutoEventWireup="true" CodeBehind="delProperty.aspx.cs" Inherits="PropertyManagementSystem.admin.delProperty" %>
<asp:Content ID="Content1" ContentPlaceHolderID="c1" runat="server">
     <div class="col-lg-12">
                    <div class="card">
                        <div class="card-header">
                            <strong class="card-title">Properties</strong>
                        </div>
                        <div class="card-body">
                            <asp:Repeater ID="r1" runat="server">
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
                                  <th scope="col">Delete</th>
                                  
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
                              <td><a href="editProperty.aspx?id=<%#Eval("id")%>">Edit</a></td>
                              <td><a href="delProperty.aspx?id=<%#Eval("id")%>">Delete</a></td>
                              
                          </tr>
                                </ItemTemplate>
                                <FooterTemplate>
                                     </tbody>
                  </table>
                                </FooterTemplate>
                                </asp:Repeater>
                            
                            
                         
                           
                         
                     
                        </div>
                         
                        <div class="alert alert-success" id="success" runat="server" style="margin-top:10px; display: none">
                            <strong>Property deleted successfully</strong>
                        </div>
                        
                    </div>
                </div>
</asp:Content>
