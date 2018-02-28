@ModelType Doxim.Models.Contact
@Code
    ViewData("Title") = "Contact Details"
End Code

<h2>Contact Details</h2>
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
</div>
<p>
    @Html.ActionLink("Edit Contact Details", "Edit Contact Details", New With {.id = Model.Id}) 
   
</p>
