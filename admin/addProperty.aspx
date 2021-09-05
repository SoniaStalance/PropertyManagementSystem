<%@ Page Title="" Language="C#" MasterPageFile="~/admin/admin.Master" AutoEventWireup="true" CodeBehind="addProperty.aspx.cs" Inherits="PropertyManagementSystem.admin.addProperty" %>
<asp:Content ID="Content1" ContentPlaceHolderID="c1" runat="server">
     <div class="col-lg-12">
                    <div class="card">
                         <div class="alert alert-success" id="Div1" runat="server" style="margin-top:10px; display: none">
                                            <strong>Property registered successfully - </strong><a href="displayProperty.aspx" class="alert-link">View Properties</a>
                                       </div>
                        <div class="card-header">
                            <strong class="card-title">Register New Property</strong>
                        </div>
                        <div class="card-body">
                          <!-- Credit Card -->
                          <div id="pay-invoice">
                              <div class="card-body">
                                  
                                  
                                  <form action="" id="for1" runat="server" method="post" novalidate="novalidate">
                                      
                                      <asp:Label ID="wardID" runat="server"></asp:Label><br />
                                      <div class="form-group">
                                          <label for="" class="control-label mb-1">Select Ward</label>
                                          <asp:DropDownList ID="ward" runat="server" CssClass="form-control" AutoPostBack="True" OnSelectedIndexChanged="ward_SelectedIndexChanged"></asp:DropDownList>
                                      </div>

                                      
                                      <asp:Label ID="ownerID" runat="server"></asp:Label><br />
                                       <div class="form-group">
                                          <label for="" class="control-label mb-1">Select Owner</label>
                                          <asp:DropDownList ID="owner" runat="server" CssClass="form-control" AutoPostBack="True" OnSelectedIndexChanged="owner_SelectedIndexChanged"></asp:DropDownList>
                                      </div>

                                      

                                      <div class="form-group">
                                          <label for="" class="control-label mb-1">Plot Area</label>
                                          <asp:TextBox ID="pa" runat="server" class="form-control"></asp:TextBox>
                                      </div>

                                       <div class="form-group">
                                          <label for="" class="control-label mb-1">Built Area</label>
                                          <asp:TextBox ID="ba" runat="server" class="form-control"></asp:TextBox>
                                      </div>

                                       <div class="form-group">
                                          <label for="" class="control-label mb-1">Select Use</label>
                                          <asp:DropDownList ID="use" runat="server" CssClass="form-control" >
                                                <asp:listitem text="Residential" value="0"></asp:listitem>
                                                <asp:listitem text="Commercial" value="1"></asp:listitem>
                                          </asp:DropDownList>
                                      </div>
                                     
                                      <div class="form-group">
                                          <label for="" class="control-label mb-1">Select Occupancy</label>
                                          <asp:DropDownList ID="occ" runat="server" CssClass="form-control" >
                                               <asp:listitem text="Self" value="0"></asp:listitem>
                                               <asp:listitem text="Tenanted" value="1"></asp:listitem>
                                          </asp:DropDownList>
                                      </div>
                                     
                                      <div>
                                          <asp:Button id="b1" runat="server" class="btn btn-lg btn-info btn-block" Text="Register" OnClick="b1_Click"  />
                                          
                                      </div>

                                      

                                     

                                  </form>
                              </div>
                          </div>

                        </div>
                    </div> <!-- .card -->

                  </div><!--/.col-->
</asp:Content>
