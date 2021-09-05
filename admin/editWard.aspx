<%@ Page Title="" Language="C#" MasterPageFile="~/admin/admin.Master" AutoEventWireup="true" CodeBehind="editWard.aspx.cs" Inherits="PropertyManagementSystem.admin.editWard" %>
<asp:Content ID="Content1" ContentPlaceHolderID="c1" runat="server">
     <div class="col-lg-12">
                    <div class="card">
                        <div class="card-header">
                            <strong class="card-title">Update Ward</strong>
                        </div>
                        <div class="card-body">
                          <!-- Credit Card -->
                          <div id="pay-invoice">
                              <div class="card-body">
                                  
                                  
                                  <form action="" id="fo3" runat="server" method="post" novalidate="novalidate">
                                      
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
                                          <asp:Button id="b1" runat="server" class="btn btn-lg btn-info btn-block" Text="Update Ward" OnClick="b1_Click" />
                                          
                                      </div>
                                       
                                      
                                  </form>
                              </div>
                          </div>

                        </div>
                    </div> <!-- .card -->

                  </div><!--/.col-->
</asp:Content>
