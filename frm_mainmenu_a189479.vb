Public Class frm_mainmenu_a189479

    Private Sub btn_view_products_Click(sender As Object, e As EventArgs) Handles btn_view_products.Click
        frm_product_details_a189479.Show()
        Me.Hide()
    End Sub

    Private Sub btn_exit_Click(sender As Object, e As EventArgs) Handles btn_exit.Click
        MsgBox("~ GoodBye ~ ")
        Application.Exit()
    End Sub

    Private Sub btn_view_customers_Click(sender As Object, e As EventArgs) Handles btn_view_customers.Click
        frm_customer_details_a189479.Show()
        Me.Hide()
    End Sub

    Private Sub btn_view_staff_Click(sender As Object, e As EventArgs) Handles btn_view_staff.Click
        frm_staff_details_a189479.Show()
        Me.Hide()
    End Sub

    Private Sub btn_view_orders_Click(sender As Object, e As EventArgs) Handles btn_view_orders.Click
        frm_view_order_a189479.Show()
        Me.Hide()
    End Sub

    Private Sub linklbl_github_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles linklbl_github.LinkClicked
        System.Diagnostics.Process.Start(githubLink)
    End Sub

    Private Sub btn_add_order_Click(sender As Object, e As EventArgs) Handles btn_add_order.Click
        frm_add_order_a189479.Show()
        Me.Hide()
    End Sub
End Class
