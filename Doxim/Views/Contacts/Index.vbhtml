@ModelType IEnumerable(Of Doxim.Models.Contact)
@Code
    ViewData("Title") = "Contacts"
End Code

<h2>Contacts List</h2>

<p>
    

    @Using Html.BeginForm("Index", "Contacts", FormMethod.Get)
@<p>
        @Html.TextBox("SearchString")


    <input class="btn btn-primary" type="submit" value="Search" />
     <button class="btn btn-danger" id="btnAddNew"> @Html.ActionLink("Add New Contact", "Create")</button>
         </p>
    End Using
</p>

<table class="table">
    <tr class="tblHeader">
        <th>
            @Html.ActionLink("First Name", "Index", New With {.sortOrder = ViewBag.FirstNameSortParm})
        </th>
        <th>
            @Html.ActionLink("Last Name", "Index", New With {.sortOrder = ViewBag.NameSortParm})
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.PhoneNum)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.Email)
        </th>
        <th>Options</th>
    </tr>

    @For Each item In Model
    @<tr>
        <td>
            @Html.DisplayFor(Function(modelItem) item.FirstName)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.LastName)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.PhoneNum)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.Email)
        </td>
        <td>
            @Html.ActionLink("Edit", "Edit", New With {.id = item.Id}) |
            @Html.ActionLink("Details", "Details", New With {.id = item.Id}) |
            @Html.ActionLink("Delete", "Delete", New With {.id = item.Id})
        </td>
    </tr>
    Next

</table>
