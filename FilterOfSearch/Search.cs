namespace FilterOfSearch
{
    public class Search
    {
        static bool status;
        public void searchButton(TextBox firstText, TextBox secondText, DataGridView accountTable)
        {
            status = false;
            if (firstText.Text != "" && secondText.Text != "")
            {
                for (int i = 0; i < accountTable.RowCount; i++)
                {
                    accountTable.Rows[i].Selected = false;
                    for (int j = 0; j < accountTable.ColumnCount; j++)
                        if (accountTable.Rows[i].Cells[j].Value != null)
                            if (accountTable.Rows[i].Cells[j].Value.ToString().Contains(firstText.Text) || accountTable.Rows[i].Cells[j].Value.ToString().Contains(secondText.Text))
                            {
                                accountTable.Rows[i].Selected = true;
                                status = true;
                                break;
                            }
                }
            }
            else if (firstText.Text == "" && secondText.Text != "")
            {
                for (int i = 0; i < accountTable.RowCount; i++)
                {
                    accountTable.Rows[i].Selected = false;
                    for (int j = 0; j < accountTable.ColumnCount; j++)
                        if (accountTable.Rows[i].Cells[j].Value != null)
                            if (accountTable.Rows[i].Cells[j].Value.ToString().Contains(secondText.Text))
                            {
                                accountTable.Rows[i].Selected = true;
                                status = true;
                                break;
                            }
                }
            }
            else if (firstText.Text != "" && secondText.Text == "")
            {
                for (int i = 0; i < accountTable.RowCount; i++)
                {
                    accountTable.Rows[i].Selected = false;
                    for (int j = 0; j < accountTable.ColumnCount; j++)
                        if (accountTable.Rows[i].Cells[j].Value != null)
                            if (accountTable.Rows[i].Cells[j].Value.ToString().Contains(firstText.Text))
                            {
                                accountTable.Rows[i].Selected = true;
                                status = true;
                                break;
                            }
                }
            }
            else
            {
                status = false;
                return;
            }
        }
    }
}