package eplayers;

import java.util.concurrent.TimeUnit;

import org.junit.Before;
import org.junit.Test;
import org.openqa.selenium.By;
import org.openqa.selenium.WebDriver;
import org.openqa.selenium.chrome.ChromeDriver;
import org.openqa.selenium.WebElement;

public class TesteLoginGameMania {
private WebDriver driver;
	
	@Before
	public void abrirNavegador() {
		System.setProperty("webdriver.chrome.driver", "C:\\Program Files (x86)\\chromedriver_win32\\chromedriver.exe");
		driver = new ChromeDriver();		
		driver.manage().window().maximize();
		}
	
	@Test
	public void testeNavegador() {
		driver.manage().timeouts().implicitlyWait(10, TimeUnit.SECONDS);
		driver.get("http://localhost:4200/login");
		driver.manage().timeouts().implicitlyWait(3, TimeUnit.SECONDS);
		
		WebElement inputEmail =	driver.findElement(By.id("email"));
		WebElement inputSenha =	driver.findElement(By.id("senha"));
		WebElement botaoLogin =	driver.findElement(By.id("btn-logar"));
			
		/* Teste com dados errados 
		inputEmail.sendKeys("fernando@email.com");
		inputSenha.sendKeys("4324342");
		botaoLogin.click();
		*/
		
		String [] listaSenhas = {"senhaerrada","raiour","tetesenha123"};
		
		for(int i = 0;i < listaSenhas.length;i++) {
			try {
				inputEmail.clear();
				inputSenha.clear();
				
				inputEmail.sendKeys("fernando@email.com");
				inputSenha.sendKeys(listaSenhas[i]);
				botaoLogin.click();	
				Thread.sleep(3000);
				
			}catch(Exception e) {
				 e.printStackTrace();
			}
			
		}
		
		
	}
}
