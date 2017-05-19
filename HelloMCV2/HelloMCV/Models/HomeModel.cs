
namespace HelloMCV.Models
{
    public class HomeModel
    {
        //ユーザが入力した値の格納変数
        public int number { get; set; }
        //カウント用変数
        public int count{ get; set; }
       //変更前結果、格納変数
        public string before { get; set; }
        //変更後結果、格納処理
        public string after { get; set; } 

    }
}