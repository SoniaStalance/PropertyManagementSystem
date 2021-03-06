<%@ Page Title="" Language="C#" MasterPageFile="~/admin/admin.Master" AutoEventWireup="true" CodeBehind="addZone.aspx.cs" Inherits="PropertyManagementSystem.admin.add" %>
<asp:Content ID="Content1" ContentPlaceHolderID="c1" runat="server">
               
                  <div class="col-lg-12">
                    <div class="card">
                        <div class="card-header">
                            <strong class="card-title">Add New Zone</strong>
                        </div>
                        <div class="card-body">
                          <!-- Credit Card -->
                          <div id="pay-invoice">
                              <div class="card-body">
                                  
                                  
                                  <form action="" id="fo1" runat="server" method="post" novalidate="novalidate">
                                      
                                      <div class="form-group">
                                          <label for="" class="control-label mb-1">Zone Name</label>
                                          <asp:TextBox ID="name" runat="server" class="form-control"></asp:TextBox>
                                      </div>
                                     
                                     
                                     
                                      <div>
                                          <asp:Button id="b1" runat="server" class="btn btn-lg btn-info btn-block" Text="Add Zone" OnClick="b1_Click" />
                                          
                                      </div>

                                       <div class="alert alert-danger" id="error" runat="server" style="margin-top:10px; display: none">
                                            <strong>Zone already exists - </strong><a href="displayZone.aspx" class="alert-link">View Zones</a>
                                       </div>

                                     

                                  </form>
                              </div>
                          </div>

                        </div>
                    </div> <!-- .card -->

                  </div><!--/.col-->
</asp:Content>
