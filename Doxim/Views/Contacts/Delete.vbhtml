@ModelType Doxim.Models.Contact
@Code
    ViewData("Title") = "Delete Contact"
End Code

<h2>Delete Contact</h2>

<h3 style="color:indianred">Are you sure you want to delete this contact?</h3>
@Html.ActionLink("Back to Contact List", "Index") 
<div>    
    <hr />
    <dl class="dl-horizontal">
        <dt>
            @Html.DisplayNameFor(Function(model) model.FirstName)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.FirstName)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.LastName)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.LastName)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.PhoneNum)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.PhoneNum)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.Email)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.Email)
        </dd>

    </dl>
    @Using (Html.BeginForm())
        @Html.AntiForgeryToken()

        @<div class="form-actions no-color">
             
            <input id="btnDelete" type="submit" value="Delete Contact" class="btn btn-danger" /> 
           
        </div>
    End Using
</div>
