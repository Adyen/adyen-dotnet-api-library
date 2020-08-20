$script = <<-SCRIPT
sudo rpm -Uvh https://packages.microsoft.com/config/rhel/7/packages-microsoft-prod.rpm
echo "Run update"
sudo yum update
echo "Install dotnet core"
sudo yum -y install dotnet-sdk-2.2
SCRIPT
Vagrant.configure("2") do |config|
  config.vm.box = "centos/7"
  config.vm.synced_folder '.', '/home/vagrant/adyen-dotnet-api-library', disabled: false
  config.vm.synced_folder '.', '/vagrant', disabled: true
  config.vm.network :forwarded_port, guest: 22, host: 3333
  config.vm.provider :virtualbox do |vb|
       vb.name = "adyen-dotnet-api-library"
       vb.customize ["modifyvm", :id, "--memory", "1024", "--cpus", "2"]
   end
  config.vm.provision "shell", inline: $script
end
