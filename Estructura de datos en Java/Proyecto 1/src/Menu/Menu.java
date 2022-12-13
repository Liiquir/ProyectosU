package Menu;

import Clases.Pais;
import java.text.DecimalFormat;
import javax.swing.JOptionPane;
import javax.swing.table.DefaultTableModel;

/**
 *
 * @author Josue
 */
public class Menu extends javax.swing.JFrame {

    Pais[] paises;

    public Menu() {
        initComponents();

        paises = new Pais[]{
            new Pais("EEUU", numRandom()),
            new Pais("Suecia", numRandom()),
            new Pais("Francia", numRandom()),
            new Pais("Alemania", numRandom()),
            new Pais("Holanda", numRandom()),
            new Pais("Canadá", numRandom()),
            new Pais("España", numRandom()),
            new Pais("Inglaterra", numRandom()),
            new Pais("Brasil", numRandom()),
            new Pais("Costa Rica", numRandom())};
        CargarTabla();      
    }

    @SuppressWarnings("unchecked")
    // <editor-fold defaultstate="collapsed" desc="Generated Code">//GEN-BEGIN:initComponents
    private void initComponents() {

        jPanel1 = new javax.swing.JPanel();
        btnMenuMostrarRanking = new javax.swing.JButton();
        jTabbedPane1 = new javax.swing.JTabbedPane();
        jPAdicionPuntos = new javax.swing.JPanel();
        jScrollPane2 = new javax.swing.JScrollPane();
        jTablePaises = new javax.swing.JTable();
        jPanel2 = new javax.swing.JPanel();
        btnAgregarPuntos = new javax.swing.JButton();
        txtPuntos = new javax.swing.JTextField();
        jLabel1 = new javax.swing.JLabel();
        jLabel2 = new javax.swing.JLabel();

        setDefaultCloseOperation(javax.swing.WindowConstants.EXIT_ON_CLOSE);
        setPreferredSize(new java.awt.Dimension(800, 500));
        getContentPane().setLayout(new org.netbeans.lib.awtextra.AbsoluteLayout());

        jPanel1.setBackground(new java.awt.Color(153, 153, 153));
        jPanel1.setPreferredSize(new java.awt.Dimension(200, 500));
        jPanel1.setLayout(new java.awt.FlowLayout(java.awt.FlowLayout.CENTER, 0, 80));

        btnMenuMostrarRanking.setBackground(java.awt.Color.lightGray);
        btnMenuMostrarRanking.setForeground(java.awt.Color.black);
        btnMenuMostrarRanking.setText("Mostrar ranking");
        btnMenuMostrarRanking.setMaximumSize(new java.awt.Dimension(195, 22));
        btnMenuMostrarRanking.setMinimumSize(new java.awt.Dimension(195, 22));
        btnMenuMostrarRanking.setPreferredSize(new java.awt.Dimension(195, 50));
        btnMenuMostrarRanking.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                btnMenuMostrarRankingActionPerformed(evt);
            }
        });
        jPanel1.add(btnMenuMostrarRanking);

        getContentPane().add(jPanel1, new org.netbeans.lib.awtextra.AbsoluteConstraints(0, 0, 226, 470));

        jTabbedPane1.setPreferredSize(new java.awt.Dimension(1300, 400));

        jTablePaises.setModel(new javax.swing.table.DefaultTableModel(
            new Object [][] {
                {null, null, null, null},
                {null, null, null, null},
                {null, null, null, null},
                {null, null, null, null}
            },
            new String [] {
                "Title 1", "Title 2", "Title 3", "Title 4"
            }
        ));
        jTablePaises.getTableHeader().setResizingAllowed(false);
        jTablePaises.getTableHeader().setReorderingAllowed(false);
        jScrollPane2.setViewportView(jTablePaises);

        btnAgregarPuntos.setText("Añadir Puntos");
        btnAgregarPuntos.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                btnAgregarPuntosActionPerformed(evt);
            }
        });

        jLabel1.setText("Cantidad de puntos a añadir:");

        javax.swing.GroupLayout jPanel2Layout = new javax.swing.GroupLayout(jPanel2);
        jPanel2.setLayout(jPanel2Layout);
        jPanel2Layout.setHorizontalGroup(
            jPanel2Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(jPanel2Layout.createSequentialGroup()
                .addComponent(jLabel1)
                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                .addGroup(jPanel2Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                    .addComponent(btnAgregarPuntos)
                    .addComponent(txtPuntos, javax.swing.GroupLayout.PREFERRED_SIZE, 99, javax.swing.GroupLayout.PREFERRED_SIZE))
                .addContainerGap(javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE))
        );
        jPanel2Layout.setVerticalGroup(
            jPanel2Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(jPanel2Layout.createSequentialGroup()
                .addContainerGap(40, Short.MAX_VALUE)
                .addGroup(jPanel2Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.BASELINE)
                    .addComponent(txtPuntos, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
                    .addComponent(jLabel1))
                .addGap(18, 18, 18)
                .addComponent(btnAgregarPuntos)
                .addGap(74, 74, 74))
        );

        jLabel2.setText("Seleccione el nombre de país al que desea agregar puntos");

        javax.swing.GroupLayout jPAdicionPuntosLayout = new javax.swing.GroupLayout(jPAdicionPuntos);
        jPAdicionPuntos.setLayout(jPAdicionPuntosLayout);
        jPAdicionPuntosLayout.setHorizontalGroup(
            jPAdicionPuntosLayout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(jPAdicionPuntosLayout.createSequentialGroup()
                .addContainerGap()
                .addGroup(jPAdicionPuntosLayout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                    .addGroup(javax.swing.GroupLayout.Alignment.TRAILING, jPAdicionPuntosLayout.createSequentialGroup()
                        .addGap(0, 0, Short.MAX_VALUE)
                        .addComponent(jScrollPane2, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE))
                    .addComponent(jPanel2, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE)
                    .addGroup(jPAdicionPuntosLayout.createSequentialGroup()
                        .addComponent(jLabel2)
                        .addGap(0, 0, Short.MAX_VALUE)))
                .addContainerGap())
        );
        jPAdicionPuntosLayout.setVerticalGroup(
            jPAdicionPuntosLayout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(jPAdicionPuntosLayout.createSequentialGroup()
                .addGap(23, 23, 23)
                .addComponent(jScrollPane2, javax.swing.GroupLayout.PREFERRED_SIZE, 188, javax.swing.GroupLayout.PREFERRED_SIZE)
                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED, 32, Short.MAX_VALUE)
                .addComponent(jLabel2)
                .addGap(29, 29, 29)
                .addComponent(jPanel2, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
                .addContainerGap())
        );

        jTabbedPane1.addTab("tab2", jPAdicionPuntos);

        getContentPane().add(jTabbedPane1, new org.netbeans.lib.awtextra.AbsoluteConstraints(232, -38, 460, 500));

        pack();
    }// </editor-fold>//GEN-END:initComponents

    private void btnMenuMostrarRankingActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_btnMenuMostrarRankingActionPerformed
        jTabbedPane1.setSelectedIndex(0);

    }//GEN-LAST:event_btnMenuMostrarRankingActionPerformed

    private void btnAgregarPuntosActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_btnAgregarPuntosActionPerformed
        try {
            float puntos = (Float.parseFloat(txtPuntos.getText()));

            if (jTablePaises.getSelectedRow() > -1) {
                int index = jTablePaises.getSelectedRow();
                paises[index].AumentarPuntos((float) (Math.round(puntos * 100.0) / 100.0));
                CargarTabla();
                JOptionPane.showMessageDialog(this, "Se han agregado los puntos al país seleccionado");
            }

        } catch (NumberFormatException e) {
            JOptionPane.showMessageDialog(this, "Ha ocurrido un error");
        }
    }//GEN-LAST:event_btnAgregarPuntosActionPerformed

    /**
     * @param args the command line arguments
     */
    public static void main(String args[]) {
        /* Set the Nimbus look and feel */
        //<editor-fold defaultstate="collapsed" desc=" Look and feel setting code (optional) ">
        /* If Nimbus (introduced in Java SE 6) is not available, stay with the default look and feel.
         * For details see http://download.oracle.com/javase/tutorial/uiswing/lookandfeel/plaf.html 
         */
        try {
            for (javax.swing.UIManager.LookAndFeelInfo info : javax.swing.UIManager.getInstalledLookAndFeels()) {
                if ("Nimbus".equals(info.getName())) {
                    javax.swing.UIManager.setLookAndFeel(info.getClassName());
                    break;
                }
            }
        } catch (ClassNotFoundException ex) {
            java.util.logging.Logger.getLogger(Menu.class.getName()).log(java.util.logging.Level.SEVERE, null, ex);
        } catch (InstantiationException ex) {
            java.util.logging.Logger.getLogger(Menu.class.getName()).log(java.util.logging.Level.SEVERE, null, ex);
        } catch (IllegalAccessException ex) {
            java.util.logging.Logger.getLogger(Menu.class.getName()).log(java.util.logging.Level.SEVERE, null, ex);
        } catch (javax.swing.UnsupportedLookAndFeelException ex) {
            java.util.logging.Logger.getLogger(Menu.class.getName()).log(java.util.logging.Level.SEVERE, null, ex);
        }
        //</editor-fold>

        /* Create and display the form */
        java.awt.EventQueue.invokeLater(new Runnable() {
            public void run() {
                new Menu().setVisible(true);
            }
        });
    }

    public float numRandom() {
        double random = Math.random() * (3000 - 1 + 1) + 1;

        return (float) (Math.round(random * 100.0) / 100.0);

    }
    // Variables declaration - do not modify//GEN-BEGIN:variables
    private javax.swing.JButton btnAgregarPuntos;
    private javax.swing.JButton btnMenuMostrarRanking;
    private javax.swing.JLabel jLabel1;
    private javax.swing.JLabel jLabel2;
    private javax.swing.JPanel jPAdicionPuntos;
    private javax.swing.JPanel jPanel1;
    private javax.swing.JPanel jPanel2;
    private javax.swing.JScrollPane jScrollPane2;
    private javax.swing.JTabbedPane jTabbedPane1;
    private javax.swing.JTable jTablePaises;
    private javax.swing.JTextField txtPuntos;
    // End of variables declaration//GEN-END:variables

    private void CargarTabla() {
        paises=OrdenamientoQuickSort(paises, 0, paises.length-1);
        Object[][] datos = new Object[paises.length][2];
        for (int i = 0; i < paises.length; i++) {

            datos[i][0] = paises[i].getNombrePais();
            datos[i][1] = paises[i].getPuntosPais();

        }
        Object[] columnas = {
            "Nombre", "Puntos"
        };

        DefaultTableModel modelo = new DefaultTableModel(datos, columnas) {
            @Override
            public boolean isCellEditable(int filas, int columna) {
                return false;
            }
        };
        jTablePaises.setModel(modelo);
    }
    //El algoritmo usado es el mismo que nos proporciona la uned en la seccion de material de apoyo del entorno.
    public static Pais[] OrdenamientoQuickSort(Pais[] numeros, int izquierda, int derecha) {

        if (izquierda >= derecha) {
            return numeros;
        }

        int i = izquierda;
        int d = derecha;

        if (izquierda != derecha) {
            int pivote;
            Pais aux;
            pivote = izquierda;
            while (izquierda != derecha) {
                while (numeros[derecha].getPuntosPais() <= numeros[pivote].getPuntosPais() && izquierda < derecha) {
                    derecha--;
                }
                while (numeros[izquierda].getPuntosPais() < numeros[pivote].getPuntosPais() && izquierda < derecha) {
                    izquierda++;
                }

                if (derecha != izquierda) {
                    aux = numeros[derecha];
                    numeros[derecha] = numeros[izquierda];
                    numeros[izquierda]=aux;
                }

                if (izquierda == derecha) {
                    OrdenamientoQuickSort(numeros, i, izquierda - 1);
                    OrdenamientoQuickSort(numeros, izquierda + 1, d);
                }

            }//Fin primer while    

        }//Fin if   
        else {

            return numeros;
        }

        return numeros;
    }

}
