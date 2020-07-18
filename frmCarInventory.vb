' Name: Ahmed Rizvi
' Date: 17-07-2020
' Description: The purpose of this program is to build a car inventory, each with their own make, model, year, price, and
'              whether the car is new or used.  

Public Class CarInventory
#Region "Constants and Variables"
    Const MIN_PRICE As Decimal = 0

    Dim cars As New List(Of Car)
    Dim editMode As Boolean = False
    Dim updatingData As Boolean = False
    Dim currentlySelectedIndex As Integer
#End Region



#Region "Event Handlers"
    ' Fills the year combo box with years 1920-2020 as soon as the form loads
    Private Sub CarInventory_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cboYear.Items.Clear() ' Clear the combo box before inputting the years
        For addYear As Integer = 1920 To 2020
            cboYear.Items.Add(addYear)
        Next
    End Sub
    ' Closes the application when the exit button is pressed
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Application.Exit()
    End Sub
    ' Resets the application when the reset button is pressed
    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        ResetForm() ' Call sub to reset form
    End Sub
    ' Takes in the values from the input fields for validation, and creates an object if the values are validated 
    Private Sub btnEnter_Click(sender As Object, e As EventArgs) Handles btnEnter.Click
        ' Store all values from input fields into new variables
        Dim inputMake As String = cboMake.Text
        Dim inputModel As String = txtModel.Text
        Dim inputYear As Integer = CInt(Val(cboYear.Text))
        Dim inputPrice As Decimal = CDec(Val(txtPrice.Text))
        Dim inputNewStatus As Boolean = chkNew.Checked

        Dim errors As String = ValidateInputs(inputMake, inputModel, inputYear, inputPrice) ' Validate the inputs
        Dim car As Car ' Create the object

        If (String.IsNullOrEmpty(errors)) Then ' Inputs were validated
            If (editMode) Then ' Editting an existing car

            Else ' Create a new car object
                car = New Car(inputMake, inputModel, inputYear, inputPrice, inputNewStatus)
                cars.Add(car)

                ResetForm()

                txtOutput.Text = "it worked!"
            End If
        Else ' Inputs were not validated
                txtOutput.Text = errors
        End If
    End Sub

#End Region

#Region "Subs and Functions"
    Function ValidateInputs(make As String, model As String, year As Integer, price As Double) As String
        Dim errorMsg As String = String.Empty
        Dim numericPrice As Double

        If (String.IsNullOrWhiteSpace(make)) Then
            errorMsg += "Please select the car's make." & Environment.NewLine
        End If

        If (String.IsNullOrWhiteSpace(model)) Then
            errorMsg += "Please enter a valid model name." & Environment.NewLine
        End If

        If (Double.TryParse(price, numericPrice)) Then
            If (numericPrice < MIN_PRICE) Then
                errorMsg += "Please enter a price that is at least $0.00" & Environment.NewLine
            End If
        Else
            errorMsg += "Please enter a numeric price." & Environment.NewLine
        End If

        Return errorMsg
    End Function
    ' Sub used to reset the form when the reset button is pressed
    Private Sub ResetForm()
        lvCarInventory.SelectedIndices.Clear()

        ' Empty the input fields
        cboMake.SelectedIndex = -1
        txtModel.Text = String.Empty
        cboYear.SelectedIndex = -1
        txtPrice.Text = String.Empty
        chkNew.Checked = False

        editMode = False ' The user is not editting

        txtOutput.Text = "Reset form"
    End Sub

    Private Sub UpdateCarInventory()

    End Sub
#End Region
End Class
