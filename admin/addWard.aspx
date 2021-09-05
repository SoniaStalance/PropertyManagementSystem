<%@ Page Title="" Language="C#" MasterPageFile="~/admin/admin.Master" AutoEventWireup="true" CodeBehind="addWard.aspx.cs" Inherits="PropertyManagementSystem.admin.addWard" %>
<asp:Content ID="Content1" ContentPlaceHolderID="c1" runat="server">
     <div class="col-lg-12">
                    <div class="card">
                        <div class="card-header">
                            <strong class="card-title">Add New Ward</strong>
                        </div>
                        <div class="card-body">
                          <!-- Credit Card -->
                          <div id="pay-invoice">
                              <div class="card-body">
                                  
                                  
                                  <form action="" id="fo2" runat="server" method="post" novalidate="novalidate">
                                      
                                      
                                      <asp:Label ID="zoneID" runat="server"></asp:Label><br />
                                      <div class="form-group">
                                          <label for="" class="control-label mb-1">Select Zone</label>
                                          <asp:DropDownList ID="zone" runat="server" CssClass="form-control" AutoPostBack="True" OnSelectedIndexChanged="zone_SelectedIndexChanged"></asp:DropDownList>
                                      </div>
                                      
                                      <div class="form-group">
                                          <label for="" class="control-label mb-1">Ward Name</label>
                                          <asp:TextBox ID="wardName" runat="server" class="form-control"></asp:TextBox>
                                      </div>
                                     
                                     
                                     
                                      <div>
                                          <asp:Button id="b1" runat="server" class="btn btn-lg btn-info btn-block" Text="Add Ward" OnClick="b1_Click" />
                                          
                                      </div>

                                       <div class="alert alert-danger" id="error" runat="server" style="margin-top:10px; display: none">
                                            <strong>Invalid zone id - </strong><a href="displayZone.aspx" class="alert-link">View Zones</a>
                                       </div>

                                       <div class="alert alert-danger" id="error1" runat="server" style="margin-top:10px; display: none">
                                            <strong>Ward already exists - </strong><a href="displayWard.aspx" class="alert-link">View Wards</a>
                                       </div>

                                      
                                      
                                       
                                  </form>
                              </div>
                          </div>

                        </div>
                    </div> <!-- .card -->

                  </div><!--/.col-->
</asp:Content>
