<%@ Page Title="" Language="C#" MasterPageFile="~/user/user.Master" AutoEventWireup="true" CodeBehind="editUserProperty.aspx.cs" Inherits="PropertyManagementSystem.user.editProperty" %>
<asp:Content ID="Content1" ContentPlaceHolderID="c1" runat="server">
    <div class="col-lg-12">
                    <div class="card">
                        <div class="card-header">
                            <strong class="card-title">Edit Property</strong>
                        </div>
                        <div class="card-body">
                          <!-- Credit Card -->
                          <div id="pay-invoice">
                              <div class="card-body">
                                  
                                  
                                  <form action="" id="fo3" runat="server" method="post" novalidate="novalidate">
                                       <asp:Label ID="pa" runat="server"></asp:Label><br />

                                      <div class="form-group">
                                          <label for="" class="control-label mb-1">Built Area</label>
                                          <asp:TextBox ID="ba" runat="server" class="form-control"></asp:TextBox>
                                      </div>

                                       <div class="form-group">
                                          <label for="" class="control-label mb-1">Use</label>
                                          <asp:DropDownList ID="use" runat="server" CssClass="form-control">
                                               <asp:listitem text="Residential" value="0"></asp:listitem>
                                                <asp:listitem text="Commercial" value="1"></asp:listitem>
                                          </asp:DropDownList>
                                      </div>

                                       <div class="form-group">
                                          <label for="" class="control-label mb-1">Occupancy</label>
                                          <asp:DropDownList ID="occ" runat="server" CssClass="form-control">
                                              
                                               <asp:listitem text="Self" value="0"></asp:listitem>
                                               <asp:listitem text="Tenanted" value="1"></asp:listitem>
                                          
                                          </asp:DropDownList>
                                      </div>
                                     
                                      <div>
                                          <asp:Button id="b1" runat="server" class="btn btn-lg btn-info btn-block" Text="Update Property" OnClick="b1_Click"/>
                                          
                                      </div>
                                       
                                      
                                  </form>
                              </div>
                          </div>

                        </div>
                    </div> <!-- .card -->

                  </div><!--/.col-->
</asp:Content>
