/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package program2_crypto;
import java.awt.Desktop;
import java.io.File;
import java.io.FileInputStream;
import java.io.FileOutputStream;
import java.io.IOException;
import java.security.InvalidKeyException;
import java.security.Key;
import java.security.NoSuchAlgorithmException;

import javax.crypto.BadPaddingException;
import javax.crypto.Cipher;
import javax.crypto.IllegalBlockSizeException;
import javax.crypto.NoSuchPaddingException;
import javax.crypto.spec.SecretKeySpec;
import javax.swing.JOptionPane;
/**
 *
 * @author jmaci
 */
public class Program2_Crypto {

    /**
     * @param args the command line arguments
     */
    static void fileProcessor(int cipherMode,String key,File inputFile,File outputFile)
    {
        try 
        {
	    Key secretKey = new SecretKeySpec(key.getBytes(), "AES");
	    Cipher cipher = Cipher.getInstance("AES");
	    cipher.init(cipherMode, secretKey);

            FileInputStream inputStream = new FileInputStream(inputFile);
	    byte[] inputBytes = new byte[(int) inputFile.length()];
	    inputStream.read(inputBytes);

	    byte[] outputBytes = cipher.doFinal(inputBytes);

	    FileOutputStream outputStream = new FileOutputStream(outputFile);
	    outputStream.write(outputBytes);

	    inputStream.close();
	    outputStream.close();

	} catch (NoSuchPaddingException | NoSuchAlgorithmException 
                   | InvalidKeyException | BadPaddingException
	           | IllegalBlockSizeException | IOException e) 
        {
            e.printStackTrace();
        }
    }
    
    public static void inicio(String a, String b) 
    {
	String key = a;
	File inputFile = new File(b);
	File encryptedFile = new File("encrypted-text.txt");
	File decryptedFile = new File("decrypted-text.txt");
		
	try 
        {
  	    Program2_Crypto.fileProcessor(Cipher.ENCRYPT_MODE,key,inputFile,encryptedFile);
	    Program2_Crypto.fileProcessor(Cipher.DECRYPT_MODE,key,encryptedFile,decryptedFile);
	    System.out.println("Sucess");
            JOptionPane.showMessageDialog(null, "Sucess");
        } catch (Exception ex) 
        {
	    System.out.println(ex.getMessage());
            ex.printStackTrace();
	}
    }
    public void openE(String archivo)
    {
        try 
        {
            File objetofile = new File (archivo);
            Desktop.getDesktop().open(objetofile);
        }catch (IOException ex) 
        {
            System.out.println(ex); 
        }
    }
    
  /* public void showE(String archivo)
   {
       try
       {
           String aux = archivo.readLine():
           
       }catch(Exception ex2)
       {
           System.out.println(ex2);
       }
   }*/
   /*public static void main(String[] args) {
        // TODO code application logic here
    }*/
    
}
