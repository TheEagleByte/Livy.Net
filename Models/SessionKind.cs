namespace Livy.Net.Models
{
    public enum SessionKind
    {
        /// <summary>
        /// Interactive Scala Spark Session
        /// </summary>
        Spark,
        
        /// <summary>
        /// Interactive Python Spark Session
        /// </summary>
        PySpark,
        
        /// <summary>
        /// Interactive R Spark Session
        /// </summary>
        SparkR,
        
        /// <summary>
        /// Interactive SQL Spark Session
        /// </summary>
        Sql
    }
}