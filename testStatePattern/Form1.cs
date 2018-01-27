using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;


namespace testStatePattern
{
    public partial class Form1 : Form
    {
        Context context =  new Context();

        public Form1()
        {
            InitializeComponent();
            // コンボボックスの設定
            object[] stateItems = {
                "Sunny", 
                "Rainy",
                "Cloudy"                                // added
            };
            comboState.Items.AddRange(stateItems);
            comboState.SelectedIndex = 0;
        }

        // コンボボックス 要素変更イベント
        private void comboState_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch ( comboState.SelectedItem.ToString() )
            {
            case "Sunny":
                setEvent(new Sunny());
                break;
            case "Rainy":
                setEvent(new Rainy());
                break;
            //-------------------------------------------> added
            case "Cloudy":
                setEvent(new Cloudy());
                break;
            //<------------------------------------------- added
            default:
                break;
            }
        }

        private void setEvent(State state)
        {
            context.changeState(state);
            setText();
        }
        private void setText()
        {
            string text = context.iceBreak() + context.chooseFastion();
            if ( textOutput.Text.Length > 0 )
            {
                textOutput.Text += "\r\n";
            }
            textOutput.Text += text;
        }
    }

    // 抽象クラス：オーバライドさせるクラス。抽象クラスは実体は作成できない。
    public abstract class State
    {
        // 抽象メソッド：派生クラスに実装を強制する
        public abstract string iceBreak();        // ※初めに話す挨拶的な意味らしい
        public abstract string chooseFastion();
    }

    // 派生クラス
    // 晴れ
    public class Sunny : State
    {
        public Sunny() { }

        // 抽象クラスを実装＝オーバライド
        public override string iceBreak()
        {
            string s = "今日は晴れている！";
            Console.WriteLine(s);
            return s;
        }
        public override string chooseFastion()
        {
            string s = "お気に入りの靴を履こう！";
            Console.WriteLine(s);
            return s;
        }
    }
    // 雨
    public class Rainy : State
    {
        public Rainy() { }

        // 抽象クラスを実装＝オーバライド
        public override string iceBreak()
        {
            string s = "今日は雨だ……";
            Console.WriteLine(s);
            return s;
        }
        public override string chooseFastion()
        {
            string s = "長靴を履こう。";
            Console.WriteLine(s);
            return s;
        }
    }

    //-------------------------------------------> added
    // 曇り
    public class Cloudy : State
    {
        public Cloudy() { }

        // 抽象クラスを実装＝オーバライド
        public override string iceBreak()
        {
            string s = "今日は曇りだ。";
            Console.WriteLine(s);
            return s;
        }
        public override string chooseFastion()
        {
            string s = "いつものスニーカーを履こー。";
            Console.WriteLine(s);
            return s;
        }
    }
    //<------------------------------------------- added

    // 状況保持クラス
    public class Context
    {
        private State state;
        public Context()
        {
            state = new Sunny();
        }

        public void changeState(State weather)
        {
            state = weather;
        }

        public string iceBreak()
        {
            return state.iceBreak();
        }

        public string chooseFastion()
        {
            return state.chooseFastion();
        }
    }
}

/*
 * 参考：
 * http://blog.goo.ne.jp/xmldtp/e/ad6b4d6777c85c3aca8048515ea9b369
 * https://qiita.com/hikao/items/e29c08d3a82bc0827a62
 * http://www.kisoplus.com/kihon/tyu.html
 * http://csharp.sevendays-study.com/ex-day4.html
 * http://takachan.hatenablog.com/entry/2016/08/10/164041
 */
