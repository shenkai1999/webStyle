package Strategy;
import java.awt.*;
import java.awt.event.*;
import javax.swing.*;

public class CrabCookingStrategy implements ItemListener
{
    private JFrame f;
    private JRadioButton qz,hs;
    private JPanel CenterJP,SouthJP;
    private Kitchen cf;    //厨房 环境类对象
    private CrabCooking qzx,hsx;    //大闸蟹加工者 抽象策略类对象
    CrabCookingStrategy()
    {
        f=new JFrame("策略模式在大闸蟹做菜中的应用");
        f.setBounds(100,100,500,400);
        f.setVisible(true);
        f.setResizable(false);
        f.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
        SouthJP=new JPanel();
        CenterJP=new JPanel();
        f.add("South",SouthJP);
        f.add("Center",CenterJP);
        qz=new JRadioButton("清蒸大闸蟹");
        hs=new JRadioButton("红烧大闸蟹");
        qz.addItemListener(this);
        hs.addItemListener(this);
        ButtonGroup group=new ButtonGroup();
        group.add(qz);
        group.add(hs);
        SouthJP.add(qz);
        SouthJP.add(hs);
        //---------------------------------
        cf=new Kitchen();    //厨房
        qzx=new SteamedCrabs();    //清蒸大闸蟹对象
        hsx=new BraisedCrabs();    //红烧大闸蟹对象
    }
    public void itemStateChanged(ItemEvent e)
    {
        JRadioButton jc=(JRadioButton) e.getSource();
        if(jc==qz)
        {
            cf.setStrategy(qzx); //设置做菜方法为清蒸
            cf.CookingMethod(); //调用清蒸方法
        }
        else if(jc==hs)
        {
            cf.setStrategy(hsx);//设置做菜方式为红烧
            cf.CookingMethod(); //调用红烧方法
        }
        CenterJP.removeAll();
        CenterJP.repaint();
        CenterJP.add((Component)cf.getStrategy());
        f.setVisible(true);
    }
    public static void main(String[] args)
    {
        new CrabCookingStrategy();
    }
}
//抽象策略类：大闸蟹加工类
interface CrabCooking
{
    public void CookingMethod();    //做菜方法
}
//具体策略类：清蒸大闸蟹
class SteamedCrabs extends JLabel implements CrabCooking
{

    public void CookingMethod()
    {
        this.setIcon(new ImageIcon("src/Strategy/SteamedCrabs.jpg"));
        this.setHorizontalAlignment(CENTER);
    }
}
//具体策略类：红烧大闸蟹
class BraisedCrabs extends JLabel implements CrabCooking
{

    public void CookingMethod()
    {
        this.setIcon(new ImageIcon("src/Strategy/BraisedCrabs.jpg"));
        this.setHorizontalAlignment(CENTER);
    }
}
//环境类：厨房 它具有设置和选择做菜策略的方法
class Kitchen
{
    private CrabCooking strategy;    //抽象策略的引用
    public void setStrategy(CrabCooking strategy)
    {
        this.strategy=strategy;
    } //实例化抽象策略类
    public CrabCooking getStrategy()
    {
        return strategy;
    }
    public void CookingMethod()
    {
        strategy.CookingMethod();    //调用做菜方法
    }

}
