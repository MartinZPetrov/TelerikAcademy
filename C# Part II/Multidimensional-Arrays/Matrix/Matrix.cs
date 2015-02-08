using System;

class Matrix
{
    private int[,] matrix;

    public Matrix(int rows, int cols)
    {
        this.matrix = new int[rows, cols];
    }


    public int Rows
    {
        get
        {
            return this.matrix.GetLength(0);
        }
    }

    public int Cols
    {
        get
        {
            return this.matrix.GetLength(1);
        }

    }

    public static Matrix operator +(Matrix first, Matrix second)
    {
        Matrix result = new Matrix(first.Rows, first.Cols);
        for (int rows = 0; rows < first.Rows; rows++)
        {
            for (int cols = 0; cols < first.Cols; cols++)
            {
                result[rows, cols] = first[rows, cols] + second[rows, cols];
            }
        }
        return result;
    }

    public static Matrix operator -(Matrix first, Matrix second)
    {
        Matrix result = new Matrix(first.Rows, first.Cols);
        for (int rows = 0; rows < first.Rows; rows++)
        {
            for (int cols = 0; cols < first.Cols; cols++)
            {
                result[rows, cols] = first[rows, cols] - second[rows, cols];
            }
        }
        return result;
    }

    public static Matrix operator *(Matrix first, Matrix second)
    {
        Matrix result = new Matrix(first.Rows, first.Cols);
        for (int rows = 0; rows < first.Rows; rows++)
        {
            for (int cols = 0; cols < first.Cols; cols++)
            {
                result[rows, cols] = first[rows, cols] * second[rows, cols];
            }
        }
        return result;
    }
    public int this[int row, int col]
    {
        get
        {
            return this.matrix[row, col];
        }
        set
        {
            this.matrix[row, col] = value;
        }
    }

    public override string ToString()
    {
        string result = null;
        
        for (int rows = 0; rows < this.Rows; rows++)
        {
            for (int cols = 0; cols < this.Cols; cols++)
            {
                result += matrix[rows, cols] + " ";
            }
           result +=  Environment.NewLine;
        }
        return result;
    }
}
