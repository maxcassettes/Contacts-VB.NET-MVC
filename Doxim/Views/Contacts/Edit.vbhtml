@ModelType Doxim.Models.Contact
@Code
    ViewData("Title") = "Edit"
End Code

<h2>Edit Contact Info</h2>
@Html.ActionLink("Back to Contact List", "Index")
@Using (Html.BeginForm())
    @Html.AntiForgeryToken()

    @<div class="form-horizontal">
        
        <hr />
        @Html.ValidationSummary(True, "", New With {.class = "text-danger"})
        @Html.HiddenFor(Function(model) model.Id)

        <div class="form-group">
            @Html.LabelFor(Function(model) model.FirstName, htmlAttributes:=New With {.class = "control-label col-md-2"})
            <div class="col-md-10">
                @Html.EditorFor(Function(model) model.FirstName, New With {.htmlAttributes = New With {.class = "form-control"}})
                @Html.ValidationMessageFor(Function(model) model.FirstName, "", New With {.class = "text-danger"})
            </div>
        </div>

        <div class="form-group">
            @Html.LabelFor(Function(model) model.LastName, htmlAttributes:=New With {.class = "control-label col-md-2"})
            <div class="col-md-10">
                @Html.EditorFor(Function(model) model.LastName, New With {.htmlAttributes = New With {.class = "form-control"}})
                @Html.ValidationMessageFor(Function(model) model.LastName, "", New With {.class = "text-danger"})
            </div>
        </div>

        <div class="form-group">
            @Html.LabelFor(Function(model) model.PhoneNum, htmlAttributes:=New With {.class = "control-label col-md-2"})
            <div class="col-md-10">
                @Html.EditorFor(Function(model) model.PhoneNum, New With {.htmlAttributes = New With {.class = "form-control"}})
                @Html.ValidationMessageFor(Function(model) model.PhoneNum, "", New With {.class = "text-danger"})
            </div>
        </div>

        <div class="form-group">
            @Html.LabelFor(Function(model) model.Email, htmlAttributes:=New With {.class = "control-label col-md-2"})
            <div class="col-md-10">
                @Html.EditorFor(Function(model) model.Email, New With {.htmlAttributes = New With {.class = "form-control"}})
                @Html.ValidationMessageFor(Function(model) model.Email, "", New With {.class = "text-danger"})
            </div>
        </div>

        <div class="form-group">
            <div class="col-md-offset-2 col-md-10">
                <input type="submit" value="Update Contact" class="btn btn-danger" />
            </div>
        </div>
    </div>
End Using


