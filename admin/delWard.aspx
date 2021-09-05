<%@ Page Title="" Language="C#" MasterPageFile="~/admin/admin.Master" AutoEventWireup="true" CodeBehind="delWard.aspx.cs" Inherits="PropertyManagementSystem.admin.delWard" %>
<asp:Content ID="Content1" ContentPlaceHolderID="c1" runat="server">
          <div class="col-lg-12">
                    <div class="card">
                        <div class="card-header">
                            <strong class="card-title">Wards</strong>
                        </div>
                        <div class="card-body">
                            <asp:Repeater ID="r1" runat="server">
                                <HeaderTemplate>
                                    <table class="table">
                              <thead>
                                <tr>
                                  
                                  <th scope="col">Ward Id</th>
                                  <th scope="col">Ward Name</th>
                                  <th scope="col">Zone</th>
                                  <th scope="col">Edit</th>
                                  <th scope="col">Delete</th>
                                  
                              </tr>
                          </thead>
                                         <tbody>
                                </HeaderTemplate>
                                <ItemTemplate>
                                     <tr>
                              <td><%#Eval("id")%></td>
                              <td><%#Eval("name")%></td>
                              <td><%#Eval("zid")%></td>
                              <td><a href="editWard.aspx?id=<%#Eval("id")%>">Edit</a></td>
                              <td><a href="delWard.aspx?id=<%#Eval("id")%>">Delete</a></td>
                              
                          </tr>
                                </ItemTemplate>
                                <FooterTemplate>
                                     </tbody>
                  </table>
                                </FooterTemplate>
                                </asp:Repeater>
                            
                            
                         
                           
                         
                     
                        </div>
                         <div class="alert alert-danger" id="error" runat="server" style="margin-top:10px; display: none">
                                            <strong>Ward cannot be deleted</strong>
                                       </div>
                        <div class="alert alert-success" id="success" runat="server" style="margin-top:10px; display: none">
                            <strong>Ward deleted successfully</strong>
                        </div>

                    </div>
                </div>
</asp:Content>
