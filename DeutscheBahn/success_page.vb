Imports MySql.Data.MySqlClient
Imports System
Imports System.IO
Imports System.Xml
Imports iTextSharp
Imports iTextSharp.text
Imports iTextSharp.text.pdf
Imports iTextSharp.text.xml
Imports System.Security

Public Class success_page
    Dim booking_id, name, train, seat, depa_date_time, stat_from_to As String

    Dim counter As Integer = 1

    Private Sub exit_btn_Click(sender As Object, e As EventArgs) Handles exit_btn.Click
        Application.Restart()
    End Sub

    Dim glo_array_inv_code, glo_array_passgr_name, glo_array_passgr_id, glo_array_seat As New ArrayList

    Private Sub print_btn_Click(sender As Object, e As EventArgs) Handles print_btn.Click
        Call printTicket(inv_code.Text)
    End Sub

    Dim total_passenger As Integer

    Private Sub next_btn_Click(sender As Object, e As EventArgs) Handles next_btn.Click
        counter = counter + 1

        If counter < total_passenger Then
            Call showBookingDetails()
        ElseIf counter = total_passenger Then
            Call showBookingDetails()
            next_btn.Enabled = False
        Else
            Me.Dispose()
            Form1.Show()
        End If

    End Sub

    Private Sub success_page_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        glo_array_inv_code.AddRange(PassengerDetail.glo_array_inv_code)
        total_passenger = glo_array_inv_code.Count
        Call showBookingDetails()

    End Sub '

    Sub showBookingDetails()
        Console.WriteLine(total_passenger)
        booking_id = PassengerDetail.glo_array_inv_code(counter - 1)
        name = PassengerDetail.glo_array_passgr_name(counter - 1)
        seat = PassengerDetail.glo_array_seat(counter - 1)

        train = train_result.selected_train_name
        depa_date_time = train_result.date_time_departure
        stat_from_to = book_form.from_text & " - " & book_form.to_text

        inv_code.Text = booking_id
        passgr_name.Text = name
        tr_seat_name.Text = seat & " - " & train
        dep_date_time.Text = depa_date_time
        station.Text = stat_from_to
    End Sub

    Public Sub printTicket(inv_id As String)
        Dim pdfFiles As String = "D:\reiseticket.pdf"
        Dim newPdfFiles As String = "D:\" & inv_id & ".pdf"

        Dim pdfName, pdfId, pdfTrain, pdfIssued, pdfSeat, pdfFromSt, pdfToSt, pdfDepDate, pdfDepTime, pdfInvId
        Dim recFromTicketTrId, recFromTicketStFrom, recFromTicketStTo As Integer

        pdfInvId = inv_id

        Call connect()
        cmd = New MySqlCommand("SELECT * FROM invoice WHERE invoice_id = '" & inv_id & "';", conn)
        rd = cmd.ExecuteReader
        rd.Read()
        If Not rd.HasRows Then
            MsgBox("Booking ID Not Found!")
        Else
            pdfName = rd.GetString("name")
            pdfId = rd.GetString("identification")
            pdfIssued = rd.GetString("date_issue")

            Call connect2()
            Dim cmd2 As New MySqlCommand
            cmd2 = New MySqlCommand("SELECT * FROM ticket WHERE tkt_id = " & Integer.Parse(rd.GetString("ticket_id")), conn2)
            rd2 = cmd2.ExecuteReader
            rd2.Read()
            If Not rd2.HasRows Then
                MsgBox("Schedule Not Found!")
            Else
                pdfDepDate = rd2.GetString("date_depart")
                pdfDepTime = rd2.GetString("time_depart")
                recFromTicketTrId = Integer.Parse(rd2.GetString("tr_id"))
                recFromTicketStFrom = Integer.Parse(rd2.GetString("std_id"))
                recFromTicketStTo = Integer.Parse(rd2.GetString("sta_id"))
            End If
            rd2.Close()
            rd2.Dispose()
            cmd2.Dispose()
            conn2.Close()

            Call connect2()
            cmd2 = New MySqlCommand("SELECT name FROM station WHERE id=" & recFromTicketStFrom.ToString, conn2)
            rd2 = cmd2.ExecuteReader
            rd2.Read()
            If Not rd2.HasRows Then
                MsgBox("Departure Station Not Found!")
            Else
                pdfFromSt = rd2.GetString("name")
            End If
            rd2.Close()
            rd2.Dispose()
            cmd2.Dispose()
            conn2.Close()

            Call connect2()
            cmd2 = New MySqlCommand("SELECT name FROM station WHERE id=" & recFromTicketStTo.ToString, conn2)
            rd2 = cmd2.ExecuteReader
            rd2.Read()
            If Not rd2.HasRows Then
                MsgBox("Arrival Station Not Found!")
            Else
                pdfToSt = rd2.GetString("name")
            End If
            rd2.Close()
            rd2.Dispose()
            cmd2.Dispose()
            conn2.Close()

            Call connect2()
            cmd2 = New MySqlCommand("SELECT name FROM series WHERE id=" & recFromTicketTrId.ToString, conn2)
            rd2 = cmd2.ExecuteReader
            rd2.Read()
            If Not rd2.HasRows Then
                MsgBox("Train Name Not Found!")
            Else
                pdfTrain = rd2.GetString("name")
            End If
            rd2.Close()
            rd2.Dispose()
            cmd2.Dispose()
            conn2.Close()

            Call connect2()
            cmd2 = New MySqlCommand("SELECT * FROM seat WHERE seat_id=" & rd.GetString("seat_id"), conn2)
            rd2 = cmd2.ExecuteReader
            rd2.Read()
            If Not rd2.HasRows Then
                MsgBox("Seat Not Found!")
            Else
                pdfSeat = rd2.GetString("seatseries") & rd2.GetString("seatnum")
            End If
            rd2.Close()
            rd2.Dispose()
            cmd2.Dispose()
            conn2.Close()

            Dim oDate As DateTime = DateTime.Parse(pdfDepDate)
            pdfDepDate = oDate.ToString("yyyy-MM-dd")


            Dim PdfReader As New PdfReader(pdfFiles)

            Dim stamper As New PdfStamper(PdfReader, New FileStream(newPdfFiles, FileMode.Create))

            Dim PdfFormFields As AcroFields = stamper.AcroFields

            PdfFormFields.SetField("passgr_name", pdfName)
            PdfFormFields.SetField("identification", pdfId)
            PdfFormFields.SetField("tr_name", pdfTrain)
            PdfFormFields.SetField("issued", pdfIssued)
            PdfFormFields.SetField("seat", pdfSeat)
            PdfFormFields.SetField("from_st", pdfFromSt)
            PdfFormFields.SetField("to_st", pdfToSt)
            PdfFormFields.SetField("dep_date", pdfDepDate & " - " & pdfDepTime)
            PdfFormFields.SetField("uuid", pdfInvId)

            stamper.FormFlattening = True

            stamper.Close()
            PdfReader.Close()

            MsgBox("Ticket Printed!, Stored at : " & newPdfFiles)
        End If
    End Sub
End Class