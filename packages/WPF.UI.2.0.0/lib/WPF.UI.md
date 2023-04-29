

# WPF.UI 使用教程

#### 介绍

WPF.UI 包是 〔NET WPF〕 推出的基于 C#.WPF 的UI库。

- 优点

实现WPF控件的属性扩展，使其支持更多的自定义属性，突破控件原有属性的限制。

将重复的样式和模板打包成通用的资源字典，大幅提高了模板化开发的便捷性，提高代码的可重用性。

- 缺点

在控件模板和触发器模板中使用时，缺乏代码智能提示，需要手动编写代码。

#### 安装教程

1. 在解决方案栏中的项目右键 -> 管理NuGet 程序包

![image-20230404110834614](C:\Users\50191\AppData\Roaming\Typora\typora-user-images\image-20230404110834614.png)

2. 在NuGet包管理器中找到WPF.UI并安装

![image-20230404111513885](C:\Users\50191\AppData\Roaming\Typora\typora-user-images\image-20230404111513885.png)

#### 使用说明

1. **添加引用**：

   ```xaml
   <!--名称可以自定义-->
   xmlns:wpfui="clr-namespace:WPF.UI;assembly=WPF.UI" 
   ```

2. **可以在资源字典、样式以及控件中使用**



> **在样式中使用**

```xml
<Style ··· >
	<Setter Property="wpfui:WPFUI.CornerRadius" Value="10 0 0 10"/>
    <Setter Property="wpfui:WPFUI.MouseOverBackground" Value="#FFC1C1C1"/>
    <Setter Property="wpfui:WPFUI.MouseOverBorderBrush" Value="#FFC1C1C1"/>
    <Setter Property="wpfui:WPFUI.CheckedBackground" Value="#FF848484"/>
    ···
</Style>
```



> 在控件模板中使用：

```xaml
<ControlTemplate TargetType="Button">
    <Border x:Name="border" CornerRadius="10" 
            Background="{TemplateBinding Background}"
            Margin="{TemplateBinding Margin}"
            BorderBrush="{TemplateBinding BorderBrush}"
            BorderThickness="{TemplateBinding wpfui:WPFUI.BorderThickness}"
            Height="{TemplateBinding Height}" Width="{TemplateBinding Width}">
        <Grid>
            <Grid.ColumnDefinitions>
                <ColumnDefinition Width="50"/>
                <ColumnDefinition Width="*"/>
                <ColumnDefinition Width="50"/>
            </Grid.ColumnDefinitions>
            <Border Background="{TemplateBinding wpfui:WPFUI.Background}" CornerRadius="{TemplateBinding wpfui:WPFUI.CornerRadius}"/>
            <Label Content="{TemplateBinding wpfui:WPFUI.Tag}" FontSize="{TemplateBinding wpfui:WPFUI.FontSize}" 
                   FontFamily="Webdings" HorizontalAlignment="Center" VerticalAlignment="Center" />
            <ContentControl Grid.Column="1" Content="{TemplateBinding Content}" VerticalAlignment="Center" HorizontalAlignment="Center"/>
            <Border Grid.Column="2" Background="{TemplateBinding wpfui:WPFUI.Background}" CornerRadius="{TemplateBinding wpfui:WPFUI.MouseOverCornerRadius}"/>
        </Grid>
    </Border>
    <ControlTemplate.Triggers>
        <Trigger Property="IsMouseOver" Value="True">
            <Setter TargetName="border" Property="BorderBrush" Value="{Binding Path=(wpfui:WPFUI.MouseOverBorderBrush),RelativeSource={RelativeSource TemplatedParent}}"/>
            <Setter TargetName="border" Property="Background" Value="{Binding Path=(wpfui:WPFUI.MouseOverBackground),RelativeSource={RelativeSource TemplatedParent}}"/>
        </Trigger>
        <Trigger Property="IsPressed" Value="True">
            <Setter TargetName="border" Property="BorderBrush" Value="{Binding Path=(wpfui:WPFUI.CheckedBorderBrush),RelativeSource={RelativeSource TemplatedParent}}"/>
            <Setter TargetName="border" Property="Background" Value="{Binding Path=(wpfui:WPFUI.CheckedBackground),RelativeSource={RelativeSource TemplatedParent}}"/>
        </Trigger>
    </ControlTemplate.Triggers>
</ControlTemplate>
```



**注意：在触发器绑定语法会有所不同**

```xaml
<Trigger Property="IsMouse" Value="True">
    <Setter TargetName="border" Property="BorderBrush" Value="{Binding Path=(wpfui:WPFUI.MouseOverBorderBrush),RelativeSource={RelativeSource TemplatedParent}}"/>
    <Setter TargetName="border" Property="Background" Value="{Binding Path=(wpfui:WPFUI.MouseOverBackground),RelativeSource={RelativeSource TemplatedParent}}"/>
</Trigger>
```




> **在控件中直接使用**

```xaml
<Button wpfui:WPFUI.Tag="WPF.UI" wpfui:WPFUI.Background="AntiqueWhite" wpfui:WPFUI.BorderBrush="Red"···/>
```



---

> 完整示例：

```xaml
<Style TargetType="Button" >
    <Setter Property="Height" Value="75"/>
    <Setter Property="Width" Value="200"/>
    <Setter Property="Tag" Value="10"/>
    <Setter Property="FontSize" Value="24"/>
    <Setter Property="wpfui:WPFUI.FontSize" Value="35"/>
    <Setter Property="wpfui:WPFUI.Tag" Value="="/>
    <Setter Property="wpfui:WPFUI.CornerRadius" Value="10 0 0 10"/>
    <Setter Property="wpfui:WPFUI.MouseOverCornerRadius" Value="0 10 10 0"/>
    <Setter Property="wpfui:WPFUI.BorderThickness" Value="1"/>
    <Setter Property="wpfui:WPFUI.Background" Value="Gray"/>
    <Setter Property="wpfui:WPFUI.MouseOverBackground" Value="#FFC1C1C1"/>
    <Setter Property="wpfui:WPFUI.MouseOverBorderBrush" Value="#FFC1C1C1"/>
    <Setter Property="wpfui:WPFUI.CheckedBackground" Value="#FF848484"/>
    <Setter Property="wpfui:WPFUI.CheckedBorderBrush" Value="#FF848484"/>
    <Setter Property="Template">
        <Setter.Value>
            <ControlTemplate TargetType="Button">
                <Border x:Name="border" CornerRadius="10" 
                        Background="{TemplateBinding Background}"
                        Margin="{TemplateBinding Margin}"
                        BorderBrush="{TemplateBinding BorderBrush}"
                        BorderThickness="{TemplateBinding wpfui:WPFUI.BorderThickness}"
                        Height="{TemplateBinding Height}" Width="{TemplateBinding Width}">
                    <Grid>
                        <Grid.ColumnDefinitions>
                            <ColumnDefinition Width="50"/>
                            <ColumnDefinition Width="*"/>
                            <ColumnDefinition Width="50"/>
                        </Grid.ColumnDefinitions>
                        <Border Background="{TemplateBinding wpfui:WPFUI.Background}" CornerRadius="{TemplateBinding wpfui:WPFUI.CornerRadius}"/>
                        <Label Content="{TemplateBinding wpfui:WPFUI.Tag}" FontSize="{TemplateBinding wpfui:WPFUI.FontSize}" 
                               FontFamily="Webdings" HorizontalAlignment="Center" VerticalAlignment="Center" />
                        <ContentControl Grid.Column="1" Content="{TemplateBinding Content}" VerticalAlignment="Center" HorizontalAlignment="Center"/>
                        <Border Grid.Column="2" Background="{TemplateBinding wpfui:WPFUI.Background}" CornerRadius="{TemplateBinding wpfui:WPFUI.MouseOverCornerRadius}"/>
                    </Grid>
                </Border>
                <ControlTemplate.Triggers>
                    <Trigger Property="IsMouseOver" Value="True">
                        <Setter TargetName="border" Property="BorderBrush" Value="{Binding Path=(wpfui:WPFUI.MouseOverBorderBrush),RelativeSource={RelativeSource TemplatedParent}}"/>
                        <Setter TargetName="border" Property="Background" Value="{Binding Path=(wpfui:WPFUI.MouseOverBackground),RelativeSource={RelativeSource TemplatedParent}}"/>
                    </Trigger>
                    <Trigger Property="IsPressed" Value="True">
                        <Setter TargetName="border" Property="BorderBrush" Value="{Binding Path=(wpfui:WPFUI.CheckedBorderBrush),RelativeSource={RelativeSource TemplatedParent}}"/>
                        <Setter TargetName="border" Property="Background" Value="{Binding Path=(wpfui:WPFUI.CheckedBackground),RelativeSource={RelativeSource TemplatedParent}}"/>
                    </Trigger>
                </ControlTemplate.Triggers>
            </ControlTemplate>
        </Setter.Value>
    </Setter>
</Style>
```
